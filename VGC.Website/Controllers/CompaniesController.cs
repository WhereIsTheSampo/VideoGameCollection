using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using VGC.Api;

namespace VGC.Website.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ISiteApi _api;

        public CompaniesController(ISiteApi api)
        {
            _api = api;
        }

        //
        // GET: /Companies/
        //
        public ActionResult Index()
        {
            IList<CompanyDto> companies = _api.GetCompanies();

            return View("Index", companies);
        }

        //
        // GET: /Companies/Details/5
        //
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Companies/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Companies/Create

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

        //
        // GET: /Companies/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Companies/Edit/5

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
        // GET: /Companies/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Companies/Delete/5

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
