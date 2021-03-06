using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Perpustakaan.Data;
using Perpustakaan.Models;

namespace Perpustakaan.Controllers
{
    
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PerpusDbContext _context;
        private UserManager<Pembaca> _userManager;

        public HomeController(ILogger<HomeController> logger, PerpusDbContext context, UserManager<Pembaca> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var user = _context.Users.Find(userId);
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Rekomendasi()
        {
            return View();
        }
        public IActionResult AthomicHabits()
        {
            return View();
        
        }
        public IActionResult Invested()
        {
            return View();
        
        }
        public IActionResult KebiasaanHidup()
        {
            return View();
        
        }
        public IActionResult OnePunchMan()
        {
            return View();
        
        }
        public IActionResult Pinjam()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}