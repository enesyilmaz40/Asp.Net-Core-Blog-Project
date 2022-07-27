using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProjeKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager blogmanager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogmanager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
