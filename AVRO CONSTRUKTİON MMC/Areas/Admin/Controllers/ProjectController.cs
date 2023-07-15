using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ProjectVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class ProjectController : Controller
    {
        private readonly AvroConstructionDbContext _context;

        public ProjectController(AvroConstructionDbContext context)
        {
            _context = context;
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
        // Create view
        //=============================

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProjectPostVM model)
        {
            return View();
        }
    }
}
