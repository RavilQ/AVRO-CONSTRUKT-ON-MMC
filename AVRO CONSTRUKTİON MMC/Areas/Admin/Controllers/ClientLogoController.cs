using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ClientLogoVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Hosting;
using Org.BouncyCastle.Asn1.Crmf;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="SuperAdmin, Admin")]
    public class ClientLogoController:Controller
    {
        private readonly AvroConstructionDbContext _context;
        private readonly IFileManager _fileManager;
        private readonly IWebHostEnvironment _env;

        public ClientLogoController(AvroConstructionDbContext context,IFileManager fileManager, IWebHostEnvironment env)
        {
            _context = context;
            _fileManager = fileManager;
            _env = env;
        }
        public IActionResult Index()
        {
            var model = new ClientLogoVM()
            {
                ClientLogos = _context.ClientLogos.ToList()
            };
            return View(model);
        }
        //=======================
        // Create
        //=======================
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ClientLogoPostVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var clientLogo = new ClientLogo()
            {
                Image = _fileManager.Save(model.ImageFile, _env.WebRootPath, "Uploads/ClientLogos", 200)
            };

            _context.ClientLogos.Add(clientLogo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var clientLoge = _context.ClientLogos.Find(id);
            if (clientLoge == null) return NotFound();

            _fileManager.Delete(_env.WebRootPath, "Uploads/ClientLogos", clientLoge.Image);

            _context.ClientLogos.Remove(clientLoge);
            _context.SaveChanges();

            return NoContent();
        }
        
    }
}
