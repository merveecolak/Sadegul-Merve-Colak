using BussApp.WebUI.Identity;
using BussApp.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.WebUI.EmailServices;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel()
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                return View(model);
            }

            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Hesabınız onaylanmamış!Lütfen mail adresinize gelen onay linkini tıklayarak, hesabınızı onaylanıyız!");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }

            ModelState.AddModelError("DİKKAT", "Şifreniz hatalı!");
            return View(model);

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)//Başarılı bir şekilde create gerçekleştiyse
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                //email gönderme işlemi
                await _emailSender.SendEmailAsync(model.Email, "MiniShopApp Confirm Account!", $"Lütfen email adresinizi onaylamak için <a href='https://localhost:5001{url}'>tıklayınız!</a>");
                ModelState.AddModelError("Kayıt işleminizi tamamlamak için mailinize gönderilen onaylama linkine tıklayınız!", "warning");
                return RedirectToAction("Login", "Account");
            }


            return View();
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                ModelState.AddModelError("", "Bir sorun oluştur");
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    ModelState.AddModelError("", "Hesabınız onaylanmıştır!");
                }
                return View();
            }

            ModelState.AddModelError("", "Hesabınız onaylanamamıştır! Lütfen daha sonra yeniden deneyiniz");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("", "Lütfen email adresinizi giriniz");
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir email adresi bulunmadı! Lütfen kontrol ederek, tekrar deneyiniz!");
                return View();
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            await _emailSender.SendEmailAsync(
                email,
                "MiniShopApp Şifre Sıfırlama",
                $"Lütfen parolanızı yenilemek için <a href='https://localhost:5001{url}'>tıklayınız.</a>"
                );
            ModelState.AddModelError("","Şifre sıfırlama linki kayıtlı mail adresinize gönderilmiştir. Lütfen kontrol ediniz.");
            return RedirectToAction("Login");
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                ModelState.AddModelError("", "Bir sorun oluştu.Daha sonra yeniden deneyiniz!");
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel()
            {
                Token = token
            };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Bir sorun oluştu, lütfen bilgileri kontrol ederek yeniden deneyiniz!");
                return View();
            }
            var result = await _userManager.ResetPasswordAsync(
                user, model.Token, model.Password
                );
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }

            ModelState.AddModelError("", "Bir sorun oluştu, lütfen admine başvurunuz.");
            return Redirect("~/");



        }
    }
}
