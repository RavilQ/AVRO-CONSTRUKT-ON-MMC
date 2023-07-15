using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AVRO_CONSTRUKTİON_MMC.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly AvroConstructionDbContext _context;

        public EmployeeController(AvroConstructionDbContext context)
        {
            _context = context;
        }

        //=========================
        // Our Team page
        //=========================

        public IActionResult Index()
        {
            var model = new EmployeeIndexViewModel
            {
                Employees = _context.Employees.Include(x => x.Job).ToList(),
                Setting = _context.Settings.ToDictionary(x => x.Key, y => y.Value)
            };
            return View(model);
        }
    }
}
