using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ServiceVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="SuperAdmin, Admin")]
    public class ServiceController : Controller
    {
        private readonly AvroConstructionDbContext _context;
        private readonly IMapper _mapper;

        public ServiceController(AvroConstructionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // =========================
        // Index
        // =========================
        public IActionResult Index()
        {
            var model = new ServiceVM()
            {
                Services = _context.Services.ToList()
            };
            return View(model);
        }
        // =========================
        // Create
        // =========================
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ServicePostVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var newService = _mapper.Map<Service>(model);

            _context.Services.Add(newService);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
       

        // =========================
        // Edit
        // =========================
        public IActionResult Edit(int id)
        {
            var service = _context.Services.Find(id);
            if (service == null) return NotFound();

            var model =  _mapper.Map<ServicePutVM>(service);

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(int id,ServicePutVM model)
        {
            var servie = _context.Services.Find(id);
            if (servie == null) return NotFound();

            if (!ModelState.IsValid) return View(model);

            servie.Title = model.Title;
            servie.Text = model.Text;
            servie.Icon = model.Icon;

            _context.Services.Update(servie);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }



        // =========================
        // Delete
        // =========================

        public IActionResult Delete(int id)
        {
            var service = _context.Services.Find(id);
            if (service == null) return NotFound();

            _context.Services.Remove(service);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
