using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.ViewModel;
using Microsoft.AspNetCore.Mvc;
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
            
                Sliders = _context.Sliders.ToList()

            };

            return View(model);
        }

    }
}