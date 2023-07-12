using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AVRO_CONSTRUKTİON_MMC.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AvroConstructionDbContext _context;

        public ProjectController(AvroConstructionDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new ProjectsViewModel()
            {
                Projects = _context.Projects.ToList()
        };

            return View(model);
        }
        public IActionResult Details(int id)
        {
            var project = _context.Projects.Find(id);
            if (project == null)
                return NotFound();
            

            return View(project);
        }
    }
}
