using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;
using System.Linq;

namespace PortfolyoSitem.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SkillsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var skills = _context.Skills.ToList();
            return View(skills);
        }
    }
}
