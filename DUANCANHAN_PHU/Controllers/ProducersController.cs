using DUANMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DUANCANHAN_PHU.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ProducersViews()
        {
            var allProducers = await _context.Producers.ToListAsync();

            return View(allProducers);
        }
    }
}
