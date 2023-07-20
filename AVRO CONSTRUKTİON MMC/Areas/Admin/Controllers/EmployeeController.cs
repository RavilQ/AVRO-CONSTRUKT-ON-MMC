using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.EmployeeVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly AvroConstructionDbContext _context;
        private readonly IPaginator _paginator;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        private readonly IWebHostEnvironment _env;

        public EmployeeController(AvroConstructionDbContext context, IPaginator paginator,IMapper mapper, IFileManager fileManager, IWebHostEnvironment env)
        {
            _context = context;
            _paginator = paginator;
            _mapper = mapper;
            _fileManager = fileManager;
            _env = env;
        }

        //=======================
        // Index View
        //=======================
        public IActionResult Index()
        {
            var model = new EmployeeIndexVM()
            {
                Employees = _context.Employees.Include(x=> x.Job).ToList()
            };

            return View(model);
        }
        //=======================
        // Create View
        //=======================

        public IActionResult Create()
        {
            var model = new EmployeePostVM()
            {
                Jobs = _context.Jobs.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(EmployeePostVM model)
        {
            model.Jobs = _context.Jobs.ToList();

            if (!ModelState.IsValid) return View(model);

            var employee = _mapper.Map<Employee>(model);
            employee.Image = _fileManager.Save(model.ImageFile, _env.WebRootPath, "Uploads/Employees", 200);

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //=======================
        // Edit
        //=======================
        public IActionResult Edit(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();

            var model = _mapper.Map<EmployeePutVM>(employee);
            model.Jobs = _context.Jobs.ToList();

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EmployeePutVM model)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();

            model.Image = employee.Image;
            model.Jobs = _context.Jobs.ToList();

            if (!ModelState.IsValid)
                return View(model);

            employee.Fullname = model.Fullname;
            employee.JobId = model.JobId;
            employee.LinkedIn = model.LinkedIn;
            employee.Email = model.Email;
            
            if(model.ImageFile is not null)
            {
                _fileManager.Delete(_env.WebRootPath, "Uploads/Employees", employee.Image);
                employee.Image = _fileManager.Save(model.ImageFile, _env.WebRootPath, "Uploads/Employees", 200);
            }
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        //=======================
        // Delete
        //=======================

        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
                return NotFound();

            _fileManager.Delete(_env.WebRootPath, "Uploads/Employees", employee.Image);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
