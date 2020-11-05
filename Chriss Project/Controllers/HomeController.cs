using Chriss_Project.Persistence;
using Chriss_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Chriss_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorldCupsService WCService;
        public HomeController(IWorldCupsService _WCService)
        {
            WCService = _WCService;
        }
        public IActionResult Index()
        {
            return View(WCService.GetWorldCups());
        }

        public string GetInfo()
        {
            return "Some Info";
        }
    }
}
