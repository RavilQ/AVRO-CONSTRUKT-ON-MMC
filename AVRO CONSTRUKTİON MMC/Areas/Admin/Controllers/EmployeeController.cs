using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
