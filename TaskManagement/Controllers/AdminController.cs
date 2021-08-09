using DemoIndentityCore.Areas.Identity.Data;
using DemoIndentityCore.Data;
using DemoIndentityCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoIndentityCore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly DemoIndentityCoreContext _db;
        public AdminController(DemoIndentityCoreContext db)
        {
            _db = db;
        }
        // GET: AdminController
        public ActionResult Index()
        {
            return View(_db.Tasks.ToList());
        }

        // GET: AdminController/Details/5
        public ActionResult Details(string id)
        {
            return View(_db.Tasks.Find(id));
        }
        //GET: AdminController/AddUser/5
        public ActionResult AddUser(string id)
        {
            ViewBag.TaskId = id;
            List<UserViewModel> listUser = new List<UserViewModel>();
            var UserTask = _db.UserTasks.Where(x => x.TaskId == id).Select(x => new UserTask //get user task have task id
            {
                UserId = x.UserId,
                TaskId = x.TaskId,
                UserTaskStatus = x.UserTaskStatus
            }).ToList();

            listUser = _db.Users.Select(x => new UserViewModel  // get all users
            {
                Id = x.Id,
                UserName = x.UserName,
                Firstname = x.Firstname,
                Email = x.Email,
                Lastname = x.Lastname,
                PhoneNumber = x.PhoneNumber
            }).ToList();
            List<UserViewModel> listUser1 = new List<UserViewModel>();
            foreach (UserTask usertask in UserTask) //  user in user task
            {
                UserViewModel user = _db.Users.Where(x => x.Id == usertask.UserId).Select(x => new UserViewModel
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Firstname = x.Firstname,
                    Email = x.Email,
                    Lastname = x.Lastname,
                    PhoneNumber = x.PhoneNumber
                }).FirstOrDefault();
                listUser1.Add(user);
            }
            //List<UserViewModel> result = listUser.Except(listUser1).ToList();
            List<String> alluserid = new List<string>();// get all id
            foreach (UserViewModel user in listUser)
            {
                alluserid.Add(user.Id);
            }
            List<String> userid = new List<string>();// get id in user task
            foreach (UserViewModel user in listUser1)
            {
                userid.Add(user.Id);
            }
            var ex = alluserid.Except(userid).ToList();// all id - id in user task

            List<UserViewModel> result = new List<UserViewModel>();
            foreach (string iduser in ex) // get user not in user task
            {
                UserViewModel user = _db.Users.Where(x => x.Id == iduser).Select(x => new UserViewModel
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Firstname = x.Firstname,
                    Email = x.Email,
                    Lastname = x.Lastname,
                    PhoneNumber = x.PhoneNumber
                }).FirstOrDefault();
                result.Add(user);
            }
            return View(result);
        }
        // GET: AdminController/AddToTask
        public ActionResult AddToTask(string UserID, string TaskID)
        {
            var usertask = new UserTask { TaskId = TaskID, UserId = UserID, UserTaskStatus = "To do" };
            _db.UserTasks.Add(usertask);
            _db.SaveChanges();
            return RedirectToAction("AddUser", new { id = TaskID});
        }
        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var task = new ITask {TaskId= collection["TaskId"], Title= collection["Title"],
                                        Contentt = collection["Contentt"],
                                        TimeStart = DateTime.Parse(collection["TimeStart"]),
                                        TaskStatus = collection["TaskStatus"],
                                        TimeEnd= DateTime.Parse(collection["TimeEnd"])                                        
                                        };
                _db.Tasks.Add(task);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ViewUserOnTask(string id)
        {
            List<UserViewModel> listUser = new List<UserViewModel>();
            var UserTask = _db.UserTasks.Where(x => x.TaskId == id).Select(x => new UserTask //get user task have task id
            {
                UserId = x.UserId,
                TaskId = x.TaskId,
                UserTaskStatus = x.UserTaskStatus
            }).ToList();
            foreach (UserTask usertask in UserTask) //  user in user task
            {
                UserViewModel user = _db.Users.Where(x => x.Id == usertask.UserId).Select(x => new UserViewModel
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Firstname = x.Firstname,
                    Email = x.Email,
                    Lastname = x.Lastname,
                    PhoneNumber = x.PhoneNumber
                }).FirstOrDefault();
                listUser.Add(user);
            }
            return View(listUser);
        }
        // GET: AdminController/Edit/5
        public ActionResult Edit(string id)
        {
            return View(_db.Tasks.Find(id));
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                var task = _db.Tasks.Find(id);
                task.Title = collection["Title"];
                task.Contentt = collection["Contentt"];
                task.TimeStart = DateTime.Parse(collection["TimeStart"]);
                task.TimeEnd = DateTime.Parse(collection["TimeEnd"]);
                task.TaskStatus = collection["TaskStatus"];
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(string id)
        {
            var task = _db.Tasks.Find(id);
            _db.Tasks.Remove(task);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        
    }
}
