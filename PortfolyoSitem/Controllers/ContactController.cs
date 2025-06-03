using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;
using PortfolyoSitem.Models;
using System.Linq;

namespace PortfolyoSitem.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Sadece en güncel (ilk) kaydı gösteriyoruz
            var contact = _context.Contacts.FirstOrDefault();
            return View(contact);
        }
    }
}
