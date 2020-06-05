﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSalesMVC.Services;

namespace WebSalesMVC.Controllers
{
    public class SellersController : Controller
    {
        public SellerService _sellerService;
        public SellersController(SellerService sellerService) {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}