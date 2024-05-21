using DUANCANHAN_PHU.Data.Servies;
using DUANMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DUANCANHAN_PHU.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }



        //phương thức không đồng bộ
        public async Task<IActionResult> ActorsViews()
        {
            var data = await _service.GetAll();

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
