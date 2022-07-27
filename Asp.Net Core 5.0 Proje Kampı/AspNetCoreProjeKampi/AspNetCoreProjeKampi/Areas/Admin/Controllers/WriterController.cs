using AspNetCoreProjeKampi.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProjeKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }


        public static List<WriterClass> writers = new List<WriterClass>()
        {
            new WriterClass
            {
                Id=1,
                name="Ayşe"
            },
            new WriterClass
            {
                Id=2,
                name="Ahmet"
            },
            new WriterClass
            {
                Id=3,
                name="Buse"
            }

        };
    }
}
