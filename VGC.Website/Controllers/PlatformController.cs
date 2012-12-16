using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using VGC.DataAccess;

namespace VGC.Website.Controllers
{
    public class PlatformController : Controller
    {
        EFDataContext _context;

        public PlatformController()
        {
            _context = new EFDataContext();
        }

        //
        // GET: /Platform/

        public ActionResult Index()
        {
            var model = _context.Platforms.ToList();

            return View(model);
        }

        //
        // GET: /Platform/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Platform/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Platform/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        //
        // GET: /Platform/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Platform/Edit/5

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

        //
        // GET: /Platform/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Platform/Delete/5

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
