﻿using Microsoft.AspNetCore.Mvc;
using SallesCoreMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesCoreMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            //Chama o metodo findAll do seller service e guarda em uma lista
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
