using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VGC.DomainModel;
using VGC.DataAccess;

namespace VGC.Website.Controllers
{
    public class Platforms2Controller : Controller
    {
        private EFDataContext db = new EFDataContext();

        //
        // GET: /Platforms2/

        public ActionResult Index()
        {
            var platforms = db.Platforms.Include(p => p.Company);
            return View(platforms.ToList());
        }

        //
        // GET: /Platforms2/Details/5

        public ActionResult Details(int id = 0)
        {
            Platform platform = db.Platforms.Find(id);
            if (platform == null)
            {
                return HttpNotFound();
            }
            return View(platform);
        }

        //
        // GET: /Platforms2/Create

        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name");
            return View();
        }

        //
        // POST: /Platforms2/Create

        [HttpPost]
        public ActionResult Create(Platform platform)
        {
            if (ModelState.IsValid)
            {
                db.Platforms.Add(platform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", platform.CompanyId);
            return View(platform);
        }

        //
        // GET: /Platforms2/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Platform platform = db.Platforms.Find(id);
            if (platform == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", platform.CompanyId);
            return View(platform);
        }

        //
        // POST: /Platforms2/Edit/5

        [HttpPost]
        public ActionResult Edit(Platform platform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(platform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", platform.CompanyId);
            return View(platform);
        }

        //
        // GET: /Platforms2/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Platform platform = db.Platforms.Find(id);
            if (platform == null)
            {
                return HttpNotFound();
            }
            return View(platform);
        }

        //
        // POST: /Platforms2/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Platform platform = db.Platforms.Find(id);
            db.Platforms.Remove(platform);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}