using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Application.Services;
using eCommerceMVC.Models;
using Entity.Dtos;
using Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceMVC.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()

        {

            var result = _productService.GetProducts();
            return View(result);

        }


    }
}
