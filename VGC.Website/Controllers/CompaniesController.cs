using System;
using System.Collections.Generic;
using System.Web.Mvc;

using VGC.Api;

namespace VGC.Website.Controllers
{
    public class CompaniesController : Controller
    {
        //===== FIELDS ========================================================

        private readonly ISiteApi _api;


        //===== INITIALIZATION ================================================

        public CompaniesController(ISiteApi api)
        {
            _api = api;
        }


        //===== ACTIONS =======================================================

        //
        // GET: /Companies/
        //
        public ActionResult Index()
        {
            IList<CompanyDto> companies = _api.GetCompanies();

            return View(companies);
        }

        //
        // GET: /Companies/Details/5
        //
        public ActionResult Details(int id)
        {
            CompanyDto company = _api.GetCompany(id);

            return View(company);
        }

        //
        // GET: /Companies/Create
        //
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Companies/Create
        //
        [HttpPost]
        public ActionResult Create(CompanyDto company)
        {

            _api.AddCompany(company);

            return RedirectToAction("Index");
        }

        //
        // GET: /Companies/Edit/5
        //
        public ActionResult Edit(Int32 id)
        {
            CompanyDto company = _api.GetCompany(id);

            return View(company);
        }

        //
        // POST: /Companies/Edit/5
        //
        [HttpPost]
        public ActionResult Edit(Int32 id, CompanyDto company)
        {
            if (id != company.Id)
                throw new InvalidOperationException("IDs do not match");

            _api.UpdateCompany(company);

            return RedirectToAction("Index");
        }

        //
        // GET: /Companies/Delete/5
        //
        [Authorize]
        public ActionResult Delete(int id)
        {
            CompanyDto company = _api.GetCompany(id);

            return View(company);
        }

        //
        // POST: /Companies/Delete/5
        //
        [HttpPost]
        public ActionResult Delete(int id, CompanyDto company)
        {
            if (id != company.Id)
                throw new InvalidOperationException("IDs do not match");

            _api.DeleteCompany(id);

            return RedirectToAction("Index");
        }
    }
}
