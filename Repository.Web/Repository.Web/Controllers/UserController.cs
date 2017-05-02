using AutoMapper;
using Repository.Data;
using Repository.Domain.Models;
using Repository.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Repository.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            IEnumerable<UserViewModel> model;

            using (repositoryContext context = new repositoryContext())
            {
                GenericRepository<user> users = new GenericRepository<user>(context);

                IEnumerable<user> usersList = users.Get();

                model = Mapper.Map<IEnumerable<UserViewModel>>(usersList);
            }
            return View(model);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            UserViewModel model = new UserViewModel();
            using(repositoryContext context=new repositoryContext())
            {
                GenericRepository<user> User = new GenericRepository<user>(context);
                model = Mapper.Map<UserViewModel>(User.GetByID(id));
            }
            return View(model);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            UserViewModel model = new UserViewModel();
            return View(model);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                using (repositoryContext context = new repositoryContext())
                {
                    user user = Mapper.Map<user>(model);
                    GenericRepository<user> users = new GenericRepository<user>(context);
                    users.Insert(user);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            UserViewModel model = new UserViewModel();
            using (repositoryContext context = new repositoryContext())
            {
                GenericRepository<user> User = new GenericRepository<user>(context);
                model = Mapper.Map<UserViewModel>(User.GetByID(id));
            }
            return View(model);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(UserViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                using (repositoryContext context = new repositoryContext())
                {
                    user user = Mapper.Map<user>(model);
                    GenericRepository<user> users = new GenericRepository<user>(context);
                    users.Update(user);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            UserViewModel model = new UserViewModel();
            using (repositoryContext context = new repositoryContext())
            {
                GenericRepository<user> User = new GenericRepository<user>(context);
                model = Mapper.Map<UserViewModel>(User.GetByID(id));
            }
            return View(model);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(UserViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                using (repositoryContext context = new repositoryContext())
                {
                    user user = Mapper.Map<user>(model);
                    GenericRepository<user> users = new GenericRepository<user>(context);
                    users.Delete(user);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
