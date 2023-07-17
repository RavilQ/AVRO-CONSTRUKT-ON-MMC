using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.AccountVMs;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailSender emailSender)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        //===========================
        // Login
        //===========================

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {

            if (!ModelState.IsValid)
                return View();

            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("", "Istifadəçi adı və ya şifrə yanlışdır.");
                return View();
            }

            if (await _userManager.IsLockedOutAsync(user))
            {
                ModelState.AddModelError("", "Həddən artıq uğursuz cəhd, 5 dəqiqə sonra cəhd edin");
                return View();

            }


           var result=  await _signInManager.PasswordSignInAsync(user, model.Password, false, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Istifadəçi adı və ya şifrə yanlışdır.");
                return View();

            }

            //Message message = new Message(new string[] { "tahiret@code.edu.az" }, "TestMail", "this is my message");
            //_emailSender.SendEmail(message);


            return RedirectToAction("index", "Dashboard");
        }




        //===========================
        // logout
        //===========================


        [Authorize(Roles ="SuperAdmin, Admin")]
        public async Task<IActionResult>  Logout()
        {

           await  _signInManager.SignOutAsync();
            return RedirectToAction("login");
        }









        //========================
        // Create Admin And Roles
        //========================




        //public async Task<IActionResult> CreateRoles()
        //{

        //    IdentityRole superAdmin = new IdentityRole("SuperAdmin");
        //    IdentityRole admin = new IdentityRole("Admin");

        //    await _roleManager.CreateAsync(superAdmin);
        //    await _roleManager.CreateAsync(admin);

        //    return Ok();
        //}
        //public async Task<IActionResult> CreateAdmin()
        //{
        //    AppUser superAdmin = new AppUser()
        //    {
        //        UserName = "SuperAdmin",
        //        IsDefaultPassword = false,
        //    };

        //    AppUser admin = new AppUser()
        //    {
        //        UserName = "Admin",
        //        IsDefaultPassword = false,
        //    };

        //    await _userManager.CreateAsync(admin, "Admin123");
        //    await _userManager.CreateAsync(superAdmin, "Admin123");

        //    await _userManager.AddToRoleAsync(superAdmin, "SuperAdmin");
        //    await _userManager.AddToRoleAsync(admin, "Admin");




        //    return Ok();
        //}
    }
}
