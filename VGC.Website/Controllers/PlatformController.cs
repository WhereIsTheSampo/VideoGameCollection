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
//    public class PlatformController : Controller
//    {
//        private EFDataContext _context;

//        public PlatformController()
//        {
//            _context = new EFDataContext();
//        }

//        //
//        // GET: /Platform/
//        //
//        public ActionResult Index()
//        {
//            var platforms = _context.Platforms.ToList();
//            var platformDtos = Mapper.Map<IList<Platform>, IList<PlatformDto>>(platforms);

//            return View(platformDtos);
//        }

//        //
//        // GET: /Platform/Details/5
//        //
//        public ActionResult Details(int id)
//        {
//            var platform = _context.Platforms.Find(id);
//            var platformDto = Mapper.Map<Platform, PlatformDto>(platform);

//            return View(platformDto);
//        }

//        //
//        // GET: /Platform/Create
//        //
//        public ActionResult Create()
//        {
//            return View();
//        }

//        //
//        // POST: /Platform/Create

//        [HttpPost]
//        public ActionResult Create(PlatformDto platformDto)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Platform/Edit/5

//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Platform/Edit/5

//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Platform/Delete/5

//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Platform/Delete/5

//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
