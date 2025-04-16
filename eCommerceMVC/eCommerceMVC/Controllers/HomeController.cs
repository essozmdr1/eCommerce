using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Application.Services;
using eCommerceMVC.Models;
using Entity.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

       public async Task<IActionResult> Index()
       {

            RegisterDto registerDto = new()
            {
               Email = "esra@gmail.com",
               Password = "Esra.1234",
               UserName = "tsaydam"
            };
            await _userService.CreateUser(registerDto);

             registerDto = new()
            {
                Email = "emir@gmail.com",
                Password = "Emir.1234",
                UserName = "emir"
            };

            await _userService.CreateUser(registerDto);

            registerDto = new()
            {
                Email = "osman@gmail.com",
                Password = "Osman.1234",
                UserName = "osman"
            };

            await _userService.CreateUser(registerDto);
            return View();

       }


    }
}
