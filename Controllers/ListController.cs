using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Perpustakaan.Data;
using Perpustakaan.Models;

namespace Perpustakaan.Controllers
{
    public class ListController : Controller
    {
        private PerpusDbContext _context;

        public ListController(PerpusDbContext context)
        {
        _context = context;
        }
        public IActionResult List()
        {
            return View(_context.Bukus.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Judul,Deskripsi")] Buku buku)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Bukus.Add(buku);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                     throw;
                }
                return RedirectToAction("List");    
            }
            return View(buku);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}