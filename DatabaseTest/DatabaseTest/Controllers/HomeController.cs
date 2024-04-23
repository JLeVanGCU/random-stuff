using DatabaseTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DatabaseTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MongoDAO _mongoDAO;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _mongoDAO = new MongoDAO();
        }

        public IActionResult Index()
        {
            string result = _mongoDAO.readAllDocuments();
            return View("Index",result);
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
