using AspNetCoreProjeKampi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProjeKampi.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Enes",
                },
                new UserComment
                {
                    ID=2,
                    UserName="Meltem",
                },
                new UserComment
                {
                    ID=3,
                    UserName="Zeynep",

                }
            };
            return View(commentValues);
        }
    }
}
