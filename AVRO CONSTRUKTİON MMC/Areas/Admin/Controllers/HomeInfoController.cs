using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.HomeInfoVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using System.Dynamic;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class HomeInfoController : Controller
    {
        private readonly AvroConstructionDbContext _context;
        private readonly IFileManager _fileManager;
        private readonly IWebHostEnvironment _env;

        // This is the section below the slider in the home page 


        public HomeInfoController(AvroConstructionDbContext context, IFileManager fileManager, IWebHostEnvironment env)
        {
            _context = context;
            _fileManager = fileManager;
            _env = env;
        }

        //==============================
        // Index
        //==============================

        public IActionResult Index()
        {
            var settings = _context.Settings.ToDictionary(x => x.Key, y => y.Value);



            var model = new HomeInfoVM()
            {
                Settings = settings
            };
            return View(model);
        }

        //==============================
        // Edit
        //==============================
        public IActionResult Edit(HomeInfoVM model)
        {
            var settings = _context.Settings.ToDictionary(x => x.Key, y => y.Value);
            model.Settings = settings;
            if (!ModelState.IsValid) return View("Index", model);


            _context.Settings.FirstOrDefault(x => x.Key == "HomeInfo_Title").Value = model.Title;
            _context.Settings.FirstOrDefault(x => x.Key == "HomeInfo_Description").Value = model.Description;
            _context.Settings.FirstOrDefault(x => x.Key == "HomeInfo_BtnText").Value = model.BtnText;
            _context.Settings.FirstOrDefault(x => x.Key == "HomeInfo_BtnLink").Value = model.BtnLink;


            var leftImage = _context.Settings.FirstOrDefault(x => x.Key == "HomeInfo_LeftImage");
            var rightImage = _context.Settings.FirstOrDefault(x => x.Key == "HomeInfo_RightImage");
            if (model.LeftImage != null && leftImage != null && leftImage.Value !=null )
            {
                _fileManager.Delete(_env.WebRootPath, "assets/images/experience", leftImage.Value);
                leftImage.Value= _fileManager.Save(model.LeftImage, _env.WebRootPath, "assets/images/experience", 200);
            }

            if (model.RightImage != null && rightImage != null && rightImage.Value != null)
            {
                _fileManager.Delete(_env.WebRootPath, "assets/images/experience", rightImage.Value);
                rightImage.Value= _fileManager.Save(model.RightImage, _env.WebRootPath, "assets/images/experience", 200);
            }




            _context.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
