using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;
using PortfolyoSitem.Models;
using System.Linq;

namespace PortfolyoSitem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                AboutInfo = _context.Abouts.FirstOrDefault(),
                Testimonials = _context.Testimonials.ToList(),
                Projects = _context.Projects.ToList()
            };

            return View(viewModel);
        }



        public IActionResult Privacy()
        {
            return View();
        }
    }
}
