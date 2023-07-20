using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ProjectVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class ProjectController : Controller
    {
        private readonly AvroConstructionDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        private readonly IWebHostEnvironment _env;

        public ProjectController(AvroConstructionDbContext context, IMapper mapper, IFileManager fileManager, IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _fileManager = fileManager;
            _env = env;
        }
        //=============================
        // Index view
        //=============================
        public IActionResult Index()
        {

            var model = new ProjectVM()
            {
                Projects = _context.Projects.ToList()
            };
            return View(model);
        
        }

        //=============================
        // Create 
        //=============================

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProjectPostVM model)
        {

            if (!ModelState.IsValid) return View(model);

            var newProject = _mapper.Map<Project>(model);
            newProject.Image = _fileManager.Save(model.ImageFile, _env.WebRootPath, "Uploads/Projects", 200);

            _context.Projects.Add(newProject);
            _context.SaveChanges();




            return RedirectToAction("Index");
        }

        //=============================
        // Edit
        //=============================

        public IActionResult Edit(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            if (project == null) return NotFound();

            var model = _mapper.Map<ProjectPutVM>(project);

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProjectPutVM model)
        {
            var project = _context.Projects.FirstOrDefault(x => x.Id == id);
            if (project == null) return NotFound();

            if (!ModelState.IsValid) return View(model);

            if(model.ImageFile is not null)
            {
                _fileManager.Delete(_env.WebRootPath, "Uploads/Projects", project.Image);
                project.Image = _fileManager.Save(model.ImageFile, _env.WebRootPath, "Uploads/Projects", 200);
            }

            project.Name = model.Name;
            project.Description = model.Description;
            project.IsFeatured = model.IsFeatured;

            _context.Projects.Update(project);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        //=============================
        // Delete
        //=============================

        public IActionResult Delete(int id)
        {
            var project = _context.Projects.Find(id);
            if (project == null) return NotFound();

            _fileManager.Delete(_env.WebRootPath, "Uploads/Projects", project.Image);
            _context.Projects.Remove(project);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
