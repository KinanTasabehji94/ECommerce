using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using ECommerce.Repositories.Interfaces;

namespace ECommerce.Controllers
{

    public class HomeController : Controller
    {
        private readonly ICategory categoryRepository;
        public HomeController(ICategory categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var categories = categoryRepository.List();
            return View(categories);
        }

    }
}
