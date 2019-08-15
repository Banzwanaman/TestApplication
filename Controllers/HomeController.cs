﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index() => View(new Dictionary<string, string>
        {
            ["Message"] = "This is the Index action"
        });
    }
}
