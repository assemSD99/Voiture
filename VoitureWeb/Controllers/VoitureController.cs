using Microsoft.AspNetCore.Mvc;
using VoitureWeb.Data;
using VoitureWeb.Models;

namespace VoitureWeb.Controllers
{
    public class VoitureController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoitureController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Voiture> objVoitureList = _context.Voitures;
            return View(objVoitureList);
        }
    }
}
