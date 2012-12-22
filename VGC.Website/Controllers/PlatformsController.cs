using System;
using System.Collections.Generic;
using System.Web.Mvc;

using VGC.Api;

namespace VGC.Website.Controllers
{
    public class PlatformsController : Controller
    {
        //===== FIELDS ========================================================

        private readonly ISiteApi _api;


        //===== INITIALIZATION ================================================

        public PlatformsController(ISiteApi api)
        {
            _api = api;
        }


        //===== ACTIONS =======================================================

        //
        // GET: /Platforms/
        //
        public ActionResult Index()
        {
            IList<PlatformDto> platforms = _api.GetPlatforms();

            return View(platforms);
        }

        //
        // GET: /Platforms/Details/5
        //
        public ActionResult Details(Int32 id)
        {
            PlatformDto platform = _api.GetPlatform(id);

            return View(platform);
        }

        //
        // GET: /Platforms/Create
        //
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Platforms/Create
        //
        [HttpPost]
        public ActionResult Create(PlatformDto platformDto)
        {
            _api.AddPlatform(platformDto);

            return RedirectToAction("Index");
        }

        //
        // GET: /Platforms/Edit/5
        //
        public ActionResult Edit(Int32 id)
        {
            PlatformDto platformDto = _api.GetPlatform(id);

            return View(platformDto);
        }

        //
        // POST: /Platforms/Edit/5
        //
        [HttpPost]
        public ActionResult Edit(Int32 id, PlatformDto platformDto)
        {
            if (id != platformDto.Id)
                throw new InvalidOperationException("IDs do not match");

            _api.UpdatePlatform(platformDto);

            return RedirectToAction("Index");
        }

        //
        // GET: /Platforms/Delete/5
        //
        [Authorize]
        public ActionResult Delete(Int32 id)
        {
            PlatformDto platformDto = _api.GetPlatform(id);

            return View(platformDto);
        }

        //
        // POST: /Platforms/Delete/5
        //
        [HttpPost]
        public ActionResult Delete(Int32 id, PlatformDto platform)
        {
            if (id != platform.Id)
                throw new InvalidOperationException("IDs do not match");

            _api.DeletePlatform(id);

            return RedirectToAction("Index");
        }
    }
}
