using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Movie_App.Data;

namespace Movie_App.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
                return View();
        }
    }
}
