using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using TheBlockProject.Models;
using TheBlockProject.ViewModels;

namespace TheBlockProject.Controllers
{
   
    public class ProfileController : Controller
    {
        private ApplicationDbContext _context;

        public ProfileController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Profile
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var user = _context.Users.Include(u => u.Gender)
                .Include(u => u.Neighborhood)
                .Include(u => u.Race)
                .Include(u => u.Language)
                .Single(u => u.Id == userId);

            var userAnswers = _context.UserAnswers.Where(ua => ua.ApplicationUserId == userId).ToList();
            var allAnswers = _context.Answers.Include(a => a.Question).ToList();

            var query = from answerItem in allAnswers
                join userAnswer in userAnswers
                on answerItem.Id equals userAnswer.AnswerId
                select answerItem;

            var viewModel = new ProfileViewModel()
            {
                User = user,
                Answers = query.ToList(),
                Biography = user.Biography ?? ""
            };

            // Load images and videos only for hosts
            if (User.IsInRole(UserType.HOST_ROLE))
            {
                // query and insert photos & videos for user

                var photos = _context.Photos.Where(p => p.UserId == userId).ToList();
                var videos = _context.Videos.Where(p => p.UserId == userId).ToList();

                viewModel.Photos = photos;
                viewModel.Videos = videos;
            }

            return View(viewModel);
        }

        public ActionResult UpdateBiography(ProfileViewModel viewModel)
        {
            ModelState.Clear();

            var userId = User.Identity.GetUserId();

            try
            {
                _context.Users.Single(u => u.Id == userId).Biography = viewModel.Biography;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Profile");
        }

        public ActionResult AddVideoUrl(ProfileViewModel viewModel)
        {
            ModelState.Clear();

            var userId = User.Identity.GetUserId();
            var newVideo = new Video()
            {
                UserId = userId,
                Url = viewModel.VideoUrl,
                DateAdded = DateTime.Now
            };
            try
            {
                _context.Videos.Add(newVideo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Profile");
        }

        public ActionResult AddPhoto(ProfileViewModel viewModel)
        {
            var image = viewModel.File;
            if (ModelState.IsValid)
            {
                var photo = new Photo();
                if (image != null)
                {
                    // attach the uplaoded image to the object before saving to Database
                    
                    photo.ImageMimeType = image.ContentLength;
                    photo.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(photo.ImageData, 0, image.ContentLength);

                    // Save image to file
                    var filename = image.FileName;
                    var filePathOriginal = Server.MapPath("/Content/Uploads/Originals");
                    var filePathThumbnail = Server.MapPath("/Content/Uploads/Thumbnails");
                    string savedFileName = Path.Combine(filePathOriginal, filename);
                    image.SaveAs(savedFileName);

                    //Read image back from file and create thumbnail from it
                    var imageFile = Path.Combine(Server.MapPath("~/Content/Uploads/Originals"), filename);
                    using (var srcImage = Image.FromFile(imageFile))
                    using (var newImage = new Bitmap(100, 100))
                    using (var graphics = Graphics.FromImage(newImage))
                    using (var stream = new MemoryStream())
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.DrawImage(srcImage, new Rectangle(0, 0, 100, 100));
                        newImage.Save(stream, ImageFormat.Png);
                        var thumbNew = File(stream.ToArray(), "image/png");
                        photo.Thumbnail = thumbNew.FileContents;
                    }

                    photo.UserId = User.Identity.GetUserId();
                    photo.DateAdded = DateTime.Now;
                    photo.Url = filePathOriginal + filename;

                    //Save model object to database
                    try
                    {
                        _context.Photos.Add(photo);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    _context.SaveChanges();
                }
                

            }

            return RedirectToAction("Index", "Profile");
        }

        public FileContentResult GetThumbnailImage(int photoId)
        {
            Photo photo = _context.Photos.FirstOrDefault(p => p.Id == photoId);
            if (photo != null)
            {
                return File(photo.Thumbnail, photo.ImageMimeType.ToString());
            }
            else
            {
                return null;
            }
        }
    }
}