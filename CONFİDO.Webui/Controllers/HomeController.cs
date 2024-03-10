using CONFİDO.Data.UnitOfWorks;
using CONFİDO.Entity;
using CONFİDO.Webui.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CONFİDO.Webui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List()
        {
            var organization = await unitOfWork.GetRepository<Organization>().GetAllAsync();

            return View(organization);
        }

        public IActionResult Privacy()
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
