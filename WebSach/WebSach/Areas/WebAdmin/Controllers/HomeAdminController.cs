using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSach.Areas.WebAdmin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: WebAdmin/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: WebAdmin/HomeAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebAdmin/HomeAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebAdmin/HomeAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: WebAdmin/HomeAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebAdmin/HomeAdmin/Edit/5
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

        // GET: WebAdmin/HomeAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebAdmin/HomeAdmin/Delete/5
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
