using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    [Area("Admin")]
    public class SliderController : Controller
    {

        private readonly AvroConstructionDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IFileManager _fileManager;
        private readonly IMapper _mapper;

        public SliderController(AvroConstructionDbContext context, IWebHostEnvironment env, IFileManager fileManager, IMapper mapper)
        {
            _context = context;
            _env = env;
            _fileManager = fileManager;
            _mapper = mapper;
        }

        //==============================
        // Index view
        //==============================

        public IActionResult Index()
        {
            var model = new SliderVM
            {
                Sliders = _context.Sliders.OrderBy(x => x.queue).ToList()
            };
            
            return View(model);
        }

        //==============================
        // Create 
        //==============================

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(SliderPostVM SliderVM)
        {
            if(!ModelState.IsValid) return View();

            Slider slider = new Slider()
            {
                Title = SliderVM.Title,
                Title2 = SliderVM.Title2,
                Text = SliderVM.Text??"",
                ButtonText = SliderVM.ButtonText,
                BtnLink = SliderVM.ButtonLink?? "#",
                queue = SliderVM.Queue,
                Image = _fileManager.Save(SliderVM.Image, _env.WebRootPath, "Uploads/Sliders",200)

            };

            _context.Sliders.Add(slider);
            _context.SaveChanges();
            
            return RedirectToAction("index");
        }

        //==============================
        // Edit
        //==============================

        public IActionResult Edit(int id)
        {

            var slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null) return NotFound();

          

            SliderPutVM sliderPut = new SliderPutVM()
            {
                CurrentImage = slider.Image,
                Title = slider.Title,
                Title2 = slider.Title2,
                ButtonLink = slider.BtnLink,
                ButtonText = slider.ButtonText,
                Queue = slider.queue,
                Text = slider.Text,
                Id = slider.Id
            };


            return View(sliderPut);
        }

        [HttpPost]
        public IActionResult  Edit(SliderPutVM SliderVm)
        {

            if (!ModelState.IsValid) return View(SliderVm);

            var existSlider = _context.Sliders.FirstOrDefault(x => x.Id == SliderVm.Id);
            if (existSlider is null) return NotFound();

            if(SliderVm.Queue < 1 || SliderVm.Queue > _context.Sliders.Max(x=> x.queue))
            {
                ModelState.AddModelError("Queue", $"Slider Sıra dəyəri {_context.Sliders.Max(x => x.queue)} ədəddən çox olmalalıdır");
                return View(SliderVm);
            }

            if (SliderVm.Queue != existSlider.queue)
            {
                 UpdateSliderOrderAsync(existSlider.Id, SliderVm.Queue);
            }

            if (SliderVm.ImageFile is not null)
            {
                _fileManager.Delete(_env.WebRootPath, "Uploads/Sliders", existSlider.Image);
                existSlider.Image = _fileManager.Save(SliderVm.ImageFile, _env.WebRootPath, "Uploads/Sliders", 200);

            }

            existSlider.Title = SliderVm.Title;
            existSlider.Title2 = SliderVm.Title2;
            existSlider.Text = SliderVm.Text;
            existSlider.ButtonText = SliderVm.ButtonText;
            existSlider.BtnLink = SliderVm.ButtonLink;

            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        //==============================
        //  Delete
        //==============================

        public IActionResult Delete(int id)
        {
            var slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
                return NotFound();

            _fileManager.Delete(_env.WebRootPath, "Uploads/Sliders", slider.Image);

            _context.Sliders.Remove(slider);
            _context.SaveChanges();

            return NoContent();
        }


        private bool UpdateSliderOrderAsync(int id, int newOrder)
        {
            var sliders = _context.Sliders.ToList();
            var slider = _context.Sliders.FirstOrDefault(X => X.Id == id);
            if (slider == null)
                return false;

            var currentOrder = slider.queue;

            if (newOrder < currentOrder)
            {
                foreach (var slide in sliders.Where(x => x.queue >= newOrder && x.queue < currentOrder))
                {
                    slide.queue++;
                }
            }
            else if (newOrder > currentOrder)
            {
                foreach (var slide in sliders.Where(x => x.queue <= newOrder && x.queue > currentOrder))
                {
                    slide.queue--;
                }
            }

            slider.queue = newOrder;

            _context.SaveChanges();

            return true;
        }

    }
}
