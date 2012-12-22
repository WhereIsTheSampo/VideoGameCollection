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
    public class Labels2Controller : Controller
    {
        private EFDataContext db = new EFDataContext();

        //
        // GET: /Labels2/

        public ActionResult Index()
        {
            var labels = db.Labels.Include(l => l.Platform);
            return View(labels.ToList());
        }

        //
        // GET: /Labels2/Details/5

        public ActionResult Details(int id = 0)
        {
            Label label = db.Labels.Find(id);
            if (label == null)
            {
                return HttpNotFound();
            }
            return View(label);
        }

        //
        // GET: /Labels2/Create

        public ActionResult Create()
        {
            ViewBag.PlatformId = new SelectList(db.Platforms, "Id", "Name");
            return View();
        }

        //
        // POST: /Labels2/Create

        [HttpPost]
        public ActionResult Create(Label label)
        {
            if (ModelState.IsValid)
            {
                db.Labels.Add(label);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlatformId = new SelectList(db.Platforms, "Id", "Name", label.PlatformId);
            return View(label);
        }

        //
        // GET: /Labels2/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Label label = db.Labels.Find(id);
            if (label == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlatformId = new SelectList(db.Platforms, "Id", "Name", label.PlatformId);
            return View(label);
        }

        //
        // POST: /Labels2/Edit/5

        [HttpPost]
        public ActionResult Edit(Label label)
        {
            if (ModelState.IsValid)
            {
                db.Entry(label).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlatformId = new SelectList(db.Platforms, "Id", "Name", label.PlatformId);
            return View(label);
        }

        //
        // GET: /Labels2/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Label label = db.Labels.Find(id);
            if (label == null)
            {
                return HttpNotFound();
            }
            return View(label);
        }

        //
        // POST: /Labels2/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Label label = db.Labels.Find(id);
            db.Labels.Remove(label);
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