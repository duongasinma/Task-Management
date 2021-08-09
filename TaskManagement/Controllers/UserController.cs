using DemoIndentityCore.Areas.Identity.Data;
using DemoIndentityCore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoIndentityCore.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly DemoIndentityCoreContext _db;
        private readonly UserManager<DemoIndentityCoreUser> _userManager;
        public UserController(DemoIndentityCoreContext db, UserManager<DemoIndentityCoreUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        // GET: UserController
        public ActionResult Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);// will give the user's userId           
            var UserTask = _db.UserTasks.Where(x => x.UserId == userId).Select(x => new UserTask {UserId =x.UserId,
                                            TaskId=x.TaskId, UserTaskStatus= x.UserTaskStatus }).ToList();            
            List<ITask> listTask = new List<ITask>() ;
            foreach(UserTask usertask in UserTask){               
                var task = _db.Tasks.Find(usertask.TaskId);               
                    listTask.Add(task);               
            }
            return View(listTask);
        }

        // GET: UserController/Details/5
        public ActionResult Details(string id)
        {
            var usertask = _db.UserTasks.Find(id, User.FindFirstValue(ClaimTypes.NameIdentifier));
            ViewBag.UserTask = usertask.UserTaskStatus;
            return View(_db.Tasks.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(string id, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var usertask = _db.UserTasks.Find(id, userId);
                usertask.UserTaskStatus = collection["Status"];
                _db.SaveChanges();
            }
                return RedirectToAction(nameof(Details));
            
        }      
    }
}
