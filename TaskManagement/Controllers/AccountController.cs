using DemoIndentityCore.Areas.Identity.Data;
using DemoIndentityCore.Data;
using DemoIndentityCore.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System.Linq;
using System.Threading.Tasks;

namespace DemoIndentityCore.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AccountController : Controller
    {
        private readonly DemoIndentityCoreContext _db;
        private readonly UserManager<DemoIndentityCoreUser> _userManager;

        // DI: Dependency Injection
        // Tiem db vao cconstructor
        public AccountController(DemoIndentityCoreContext db, UserManager<DemoIndentityCoreUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        // GET: AccountController
        public ActionResult Index()
        {
            var lstUser = _db.Users.Select(x => new UserViewModel{ Id= x.Id,
            UserName = x.UserName, Firstname=x.Firstname, Email = x.Email,
            Lastname = x.Lastname, PhoneNumber = x.PhoneNumber}).ToList();
            return View(lstUser);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(string id)
        {
            var user_detail = _db.Users.Where(x => x.Id == id).Select(
                x => new UserViewModel
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Firstname = x.Firstname,
                    Email = x.Email,
                    Lastname = x.Lastname,
                    PhoneNumber = x.PhoneNumber
                }
                ).FirstOrDefault();
                
            return View(user_detail);
        }

        // GET: AccountController/Create 
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                var user = new DemoIndentityCoreUser { 
                    UserName = collection["UserName"],
                    Email = collection["Email"],
                    Firstname = collection["Firstname"],
                    Lastname = collection["Lastname"],
                    PhoneNumber = collection["PhoneNumber"]
                    };
                var result = await _userManager.CreateAsync(user, "Admin*123");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(string id)
        {
            //Lay lai tt cua user co id bang id truyen vao
            var user_detail = _db.Users.Where(x => x.Id == id).Select(
                x => new UserViewModel
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Firstname = x.Firstname,
                    Email = x.Email,
                    Lastname = x.Lastname,
                    PhoneNumber = x.PhoneNumber
                }
                ).FirstOrDefault();

            return View(user_detail);
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                // Lay user co Id= id
                var user = _db.Users.Where(x => x.Id == id).FirstOrDefault();
                user.Firstname = collection["Firstname"];
                user.Lastname = collection["Lastname"];
                user.PhoneNumber = collection["PhoneNumber"];
                var result = await _userManager.UpdateAsync(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public async Task<ActionResult> DeleteAsync(string id)
        {
            //lay lai user co Id = id
            var user = _db.Users.Where(x => x.Id == id).FirstOrDefault();

            var result = await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }

        // POST: AccountController/Delete/5
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
