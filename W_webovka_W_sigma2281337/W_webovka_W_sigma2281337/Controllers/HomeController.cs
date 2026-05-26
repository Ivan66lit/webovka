using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using W_webovka_W_sigma2281337.Models;
using W_webovka_W_sigma2281337.Data;

namespace W_webovka_W_sigma2281337.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Services(OrderSubmission submission)
        {
            if (ModelState.IsValid)
            {
                _context.OrderSubmissions.Add(submission);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(submission);
        }

        public IActionResult Investments()
        {
            return View();
        }

        public IActionResult About()
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