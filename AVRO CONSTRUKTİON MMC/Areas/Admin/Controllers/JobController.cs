using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.JobVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    [Area("Admin")]
    public class JobController : Controller
    {
        private readonly AvroConstructionDbContext _context;

        public JobController(AvroConstructionDbContext context)
        {
            _context = context;
        }

        //========================
        // Index view
        //========================
        public IActionResult Index()
        {
            var model = _context.Jobs.ToList();
            return View(model);
        }


        //========================
        // Create
        //========================

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(JobPostVM model)
        {
            if (!ModelState.IsValid) return View();

            Job job = new Job()
            {
                Name = model.Name,
            };

            _context.Jobs.Add(job);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        //========================
        // Edit
        //========================

        public IActionResult Edit(int id)
        {
            var job = _context.Jobs.FirstOrDefault(x => x.Id == id);
            if (job is null) return NotFound();

            JobPostVM model = new JobPostVM()
            {
                Name = job.Name,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(int id,JobPostVM model)
        {
            if (!ModelState.IsValid) return View(model);
            var job = _context.Jobs.FirstOrDefault(x => x.Id == id);
            if(job is null) return NotFound();

            job.Name = model.Name;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //========================
        // Delete
        //========================

        public IActionResult Delete(int id)
        {
            var job = _context.Jobs.FirstOrDefault(x => x.Id == id);
            if (job is null) return NotFound();

            _context.Jobs.Remove(job);
            _context.SaveChanges();

            return NoContent();
        }


    }
}
