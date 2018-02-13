﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ErrorReporter.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErrorReporter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ErrorRepository errorRepository;

        public HomeController(ErrorRepository errorRepository)
        {
            this.errorRepository = errorRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
