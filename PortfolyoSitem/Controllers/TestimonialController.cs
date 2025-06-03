using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;
using System.Linq;

namespace PortfolyoSitem.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestimonialController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var testimonials = _context.Testimonials.ToList();
            return View(testimonials);
        }
    }
}
