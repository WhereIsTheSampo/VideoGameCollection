//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//using AutoMapper;

//using VGC.Api;
//using VGC.DataAccess;
//using VGC.DomainModel;
//using VGC.Website.Models;

//namespace VGC.Website.Controllers
//{
//    public class CompanyController : Controller
//    {
//        private EFDataContext _context;

//        public CompanyController()
//        {
//            _context = new EFDataContext();
//        }

//        //
//        // GET: /Company/
//        //
//        public ActionResult Index()
//        {
//            var companies = _context.Companies.ToList();
//            var companyDtos = Mapper.Map<IList<Company>, IList<CompanyDto>>(companies);

//            return View(companyDtos);
//        }

//        //
//        // GET: /Company/Details/5
//        //
//        public ActionResult Details(int id)
//        {
//            var company = _context.Companies.Find(id);
//            var companyDto = Mapper.Map<Company, CompanyDto>(company);

//            return View(companyDto);
//        }

//        //
//        // GET: /Company/Create
//        //
//        public ActionResult Create()
//        {
//            return View();
//        }

//        //
//        // POST: /Company/Create
//        //
//        [HttpPost]
//        public ActionResult Create(CompanyDto companyDto)
//        {
//            try
//            {
//                var company = new Company
//                {
//                    Name = companyDto.Name,
//                    Notes = companyDto.Notes
//                };

//                _context.Companies.Add(company);
//                _context.SaveChanges();

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Company/Edit/5
//        //
//        public ActionResult Edit(int id)
//        {
//            var company = _context.Companies.Find(id);
//            var companyDto = Mapper.Map<Company, CompanyDto>(company);

//            return View(companyDto);
//        }

//        //
//        // POST: /Company/Edit/5
//        //
//        [HttpPost]
//        public ActionResult Edit(int id, CompanyDto companyDto)
//        {
//            try
//            {
//                var company = _context.Companies.Find(id);
//                company.Name = companyDto.Name;
//                company.Notes = companyDto.Notes;

//                _context.SaveChanges();

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Company/Delete/5
//        //
//        public ActionResult Delete(int id)
//        {
//            var company = _context.Companies.Find(id);
//            var companyDto = Mapper.Map<Company, CompanyDto>(company);

//            return View(companyDto);
//        }

//        //
//        // POST: /Company/Delete/5
//        //
//        [HttpPost]
//        public ActionResult Delete(int id, CompanyDto companyDto)
//        {
//            try
//            {
//                var company = _context.Companies.Find(id);
//                _context.Companies.Remove(company);

//                _context.SaveChanges();

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
