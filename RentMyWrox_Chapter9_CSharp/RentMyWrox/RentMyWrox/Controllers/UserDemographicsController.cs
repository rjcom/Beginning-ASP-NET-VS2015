﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentMyWrox.Models;

namespace RentMyWrox.Controllers
{
    public class UserDemographicsController : Controller
    {
        // GET: UserDemographics
        public ActionResult Index()
        {
            using (RentMyWroxContext context = new RentMyWroxContext())
            {
                var list = context.UserDemographics.OrderBy(x => x.Birthdate).ToList();
                return View(list);
            }
        }

        // GET: UserDemographics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserDemographics/Create
        public ActionResult Create()
        {
            return View("Manage");
        }

        // POST: UserDemographics/Create
        [HttpPost]
        public ActionResult Create(UserDemographics obj)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDemographics/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new UserDemographics();
            return View("Manage", model);

        }

        // POST: UserDemographics/Edit/5
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

        // GET: UserDemographics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserDemographics/Delete/5
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
