using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.Profiles;
using AVRO_CONSTRUKTİON_MMC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Math.EC;
using System.Diagnostics;

namespace AVRO_CONSTRUKTİON_MMC.Controllers
{
    public class HomeController : Controller
    {

        private readonly AvroConstructionDbContext _context;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public HomeController(AvroConstructionDbContext context, IEmailSender emailSender, IMapper mapper)
        {
            _context = context;
            _emailSender = emailSender;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {

                Sliders = _context.Sliders.OrderBy(x=> x.queue).ToList(),
                Employees = _context.Employees.Include(x => x.Job).Take(4).ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Services = _context.Services.ToList(),
                Settings = _context.Settings.ToDictionary(x => x.Key, y => y.Value),
                Projects = _context.Projects.Where(x => x.IsFeatured).ToList(),
                ClientLogos = _context.ClientLogos.ToList()
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
        [HttpPost]
        public IActionResult ContactUs(ContactPostViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var contactMessage = _mapper.Map<ContactMessage>(model);

            _context.ContactMessages.Add(contactMessage);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}