using AutoMapper;
using Repository.Data;
using Repository.Domain.Models;
using Repository.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Repository.Web.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            IEnumerable<NewsViewModel> model;

            using (repositoryContext context = new repositoryContext())
            {
                GenericRepository<news> news = new GenericRepository<news>(context);

                IEnumerable<news> newsList = news.Get();

                model = Mapper.Map<IEnumerable<NewsViewModel>>(newsList);
            }
            return View(model);
        }

        // GET: News/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: News/Create
        public ActionResult Create()
        {
            NewsViewModel model = new NewsViewModel();
            return View(model);
        }

        // POST: News/Create
        [HttpPost]
        public ActionResult Create(NewsViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                using(repositoryContext context=new repositoryContext())
                {
                    news News = Mapper.Map<news>(model);
                    GenericRepository<news> news = new GenericRepository<news>(context);
                    news.Insert(News);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: News/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: News/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: News/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
