using AVRO_CONSTRUKTİON_MMC.DAL;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult OurTeam()
        {
            return View();
        }
    }
}
