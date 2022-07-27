using AspNetCoreProjeKampi.Areas.Admin.Models;
using AspNetCoreProjeKampi.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProjeKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Moderator")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _rolemanager;
        private readonly UserManager<AppUser> _usermanager;

        public AdminRoleController(RoleManager<AppRole> rolemanager, UserManager<AppUser> usermanager)
        {
            _rolemanager = rolemanager;
            _usermanager = usermanager;
        }

        public IActionResult Index()
        {
            var values = _rolemanager.Roles.ToList();
            return View(values);
        }
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole()
                {
                    Name = model.name
                };
                var result = await _rolemanager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _rolemanager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel model = new RoleUpdateViewModel()
            {
                Id = values.Id,
                name = values.Name
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
        {
            var values = _rolemanager.Roles.Where(x => x.Id == model.Id).FirstOrDefault();
            values.Name = model.name;
            var result = await _rolemanager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _rolemanager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _rolemanager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UserRoleList()
        {
            var values = _usermanager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _usermanager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _rolemanager.Roles.ToList();

            TempData["UserId"] = user.Id;

            var userRoles = await _usermanager.GetRolesAsync(user);

            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleID = item.Id;
                m.Name = item.Name;
                m.Exists = userRoles.Contains(item.Name);
                model.Add(m);
            }


            return View(model);



        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userid = (int)TempData["UserId"];
            var user = _usermanager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in model)
            {
                if (item.Exists)
                {
                    await _usermanager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _usermanager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserRoleList");
        }
    }

}
