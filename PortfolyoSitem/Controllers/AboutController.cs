using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;
using PortfolyoSitem.Models;
using System.Linq;

namespace PortfolyoSitem.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts.FirstOrDefault();
            return View(about);
        }
    }
}
