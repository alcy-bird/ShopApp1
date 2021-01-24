using Microsoft.AspNetCore.Mvc;
using ShopApp.webui.Models;
using System.Collections.Generic;

namespace ShopApp.WEBUI.Contollers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone 12", Price = 20000, Description = "önceki gibi" };
            ViewData["Product"] = product;
            ViewData["Category"] = "Telefonlar";
            return View();
        }
        //localhost:5000/product/list
        public IActionResult List()
        {
            var Products = new List<Product>()
            {
                new Product{Name="Iphone 12",Price=21000,Description="öhh ama",IsApproved=true},
                new Product{Name="Iphone xs",Price=15000,Description="uu üç kamera",IsApproved=false}
            };
            var category = new Category { Name="telefonlar",Descriptoin="telefon kategorisi"};
            var productViewModel = new ProductViewModel()
            {
                Category = category,
                Products = Products

            };
            return View(Products);
        }
        public IActionResult Details()
        {
            //ViewBag.Name = "samsung  s21";
            //ViewBag.price = 21000;
            //ViewBag.Description = "120mp kamera ile çarpıcı";
            var P = new Product();
            P.Name = "Samsung S21";
            P.Price = 25000;
            P.Description = "pahalı hacı";
            return View(P);
        }
    }
}
