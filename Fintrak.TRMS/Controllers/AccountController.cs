using AspNetCoreHero.ToastNotification.Abstractions;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services;
using Fintrak.TRMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Fintrak.TRMS.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        IAccountRepository _accountRepository;
        private readonly TokenStorageService _tokenStorageService;
        private readonly INotyfService _notyf;

        public AccountController(ILogger<AccountController> logger, IAccountRepository accountRepository, TokenStorageService tokenStorageService, INotyfService notyf)
        {
            _logger = logger;
            _accountRepository = accountRepository;
            _tokenStorageService = tokenStorageService;
            _notyf = notyf;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Token token = _accountRepository.Login(login).Result;
                    //_tokenStorageService.StoreToken(token.access_token);

                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    string innerMessage = ex.InnerException.Message;

                    if (int.TryParse(innerMessage, out int statusCode))
                    {
                        object responseModel = ex.InnerException.InnerException.Message.ToString();
                        _notyf.Error(statusCode + " | " + responseModel);
                    }
                    else
                    {
                        _notyf.Error(500 + " | " + ex.InnerException.Message);
                    }
                }
                //ViewBag.ErrorMessage = "Invalid username or password.";
            }

            return View(login);
        }
    }
}
