﻿using DUANMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DUANCANHAN_PHU.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var allMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Price).ToListAsync();

            return View(allMovies);
        }
    }
}
