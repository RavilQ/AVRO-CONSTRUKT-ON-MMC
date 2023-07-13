using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ContactMessageVMs;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="SuperAdmin, Admin")]
    public class ContactMessageController : Controller
    {
        private readonly AvroConstructionDbContext _context;
        private readonly IEmailSender _emailSender;

        public ContactMessageController(AvroConstructionDbContext context, IEmailSender emailSender)
        {
            _context = context;
            _emailSender = emailSender;
        }
        //====================
        // Index
        //====================

        public IActionResult Index()
        {
            var model = _context.ContactMessages.Include(x=> x.ContactMessageRepy).OrderByDescending(x => x.IsReplied != true).ThenByDescending(x=> x.CreatedAt).ToList();
            
            return View(model);
        }   
        //====================
        // Delete
        //====================
        public IActionResult Delete(int id)
        {
            var contactMessage = _context.ContactMessages.FirstOrDefault(x => x.Id == id);
            if (contactMessage == null) return NotFound();
            
            _context.ContactMessages.Remove(contactMessage);
            _context.SaveChanges();

            return Ok();
        }
        //====================
        // Reply
        //====================
        public IActionResult Reply(int id)
        {
            var contactMessage = _context.ContactMessages.FirstOrDefault(x => x.Id == id);
            if (contactMessage == null) return NotFound();

            return View();
        }
        [HttpPost]
        public IActionResult Reply(int id,ContactReplyVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var contactMessage = _context.ContactMessages.FirstOrDefault(x => x.Id == id);
            if (contactMessage == null) return NotFound();

            var reply = new ContactMessageReply()
            {
                ContactMessageId = contactMessage.Id,
                Message = model.Message,
                Subject = model.Subject
            };
            contactMessage.IsReplied = true;

            Message message = new Message(new string[] { contactMessage.Email }, model.Subject, model.Message);
            _emailSender.SendEmail(message);

            _context.contactMessageReplies.Add(reply);
            _context.SaveChanges();

            return RedirectToAction("Index") ;
        }

        //=====================
        // Show Reply
        //=====================

        public IActionResult ShowReply(int id)
        {
            var model = _context.contactMessageReplies.Include(x=> x.ContactMessage).FirstOrDefault(x=> x.Id == id);
            if(model == null) return NotFound();

            return View(model);
        }
    }
}
