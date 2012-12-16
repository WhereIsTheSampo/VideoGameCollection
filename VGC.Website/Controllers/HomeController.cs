using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AutoMapper;

using VGC.DataAccess;
using VGC.DomainModel;
using VGC.Website.Models;

namespace VGC.Website.Controllers
{
    public class HomeController : Controller
    {
        EFDataContext _context;

        public HomeController()
        {
            _context = new EFDataContext();
        }

        public ActionResult Index()
        {
            var games = _context.Games.ToList();
            var gameDtos = Mapper.Map<IList<Game>, IList<GameDto>>(games);

            return View(gameDtos);
        }
    }
}
