using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AVRO_CONSTRUKTİON_MMC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AvroConstructionDbContext _context;

        public HomeController(AvroConstructionDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {

                Sliders = _context.Sliders.ToList(),
                Employees = _context.Employees.Include(x => x.Job).ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Services = _context.Services.ToList()

            };

            return View(model);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}