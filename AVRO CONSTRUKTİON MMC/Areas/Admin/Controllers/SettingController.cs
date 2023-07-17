using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.SettingVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly AvroConstructionDbContext _context;

        public SettingController(AvroConstructionDbContext context)
        {
            _context = context;
        }

        //==============================
        // Index view
        //==============================

        public IActionResult Index()
        {

            var settings = _context.Settings.Skip(6).ToList();

            return View(settings);
        }

        //==============================
        // Edit 
        //==============================

        public IActionResult Edit(int id)
        {
            var setting = _context.Settings.FirstOrDefault(x => x.Id == id);
            if (setting is null) return NotFound();

            SettingPostVM model = new SettingPostVM()
            {
                Value = setting.Value
            };

            ViewBag.Key = setting.Key;
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(int id, SettingPostVM model)
        {
            var setting = _context.Settings.FirstOrDefault(x => x.Id == id);
            if (setting is null) return NotFound();
            ViewBag.Key = setting.Key;


            if (!ModelState.IsValid) return View(model);

            setting.Value = model.Value;

            _context.Settings.Update(setting);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
