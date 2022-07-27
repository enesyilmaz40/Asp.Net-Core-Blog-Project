using AspNetCoreProjeKampi.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProjeKampi.Controllers
{

    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        private readonly UserManager<AppUser> _userManager;
        UserManager userManager = new UserManager(new EfUserRepository());

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {

            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();

        }
        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            AddProfileImage model = new AddProfileImage();
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
        
            model.WriterMail = values.Email;
            model.WriterName = values.NameSurname;
            model.WriterUserName = values.UserName;
            return View(model);

        }

        [HttpPost]

        //Parametrede UserUpdateViewModel vardı.
        public async Task<IActionResult> WriterEditProfile(AddProfileImage model)
        {
            Writer w = new Writer();
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            values.Email = model.WriterMail;
            values.NameSurname = model.WriterName;
            if (model.WriterImage != null)
            {
                var extension = Path.GetExtension(model.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                model.WriterImage.CopyTo(stream);
                values.ImageUrl = newimagename;
            }


            if (model.WriterPassword != null)
            {
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.WriterPassword);
            }
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");




            //Eski 
            //var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //values.NameSurname = model.namesurname;
            //values.ImageUrl = model.imageurl;
            //values.Email = model.mail;
            //if (model.password != null)
            //{
            //    values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            //}
            //var result = await _userManager.UpdateAsync(values);
            //return RedirectToAction("Index", "Dashboard");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");

        }
    
    }
}
