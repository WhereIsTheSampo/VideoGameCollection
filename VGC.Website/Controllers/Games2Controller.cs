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
    public class Games2Controller : Controller
    {
        private EFDataContext db = new EFDataContext();

        //
        // GET: /Games2/

        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }

        //
        // GET: /Games2/Details/5

        public ActionResult Details(int id = 0)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        //
        // GET: /Games2/Create

        public ActionResult Create()
        {
            ViewBag.PlatformId = new SelectList(db.Platforms, "Id", "Name");
            ViewBag.LabelId = new SelectList(db.Labels, "Id", "Name");
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name");
            return View();
        }

        //
        // POST: /Games2/Create

        [HttpPost]
        public ActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }

        //
        // GET: /Games2/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        //
        // POST: /Games2/Edit/5

        [HttpPost]
        public ActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        //
        // GET: /Games2/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        //
        // POST: /Games2/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
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