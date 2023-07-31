using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using thales.Models;
using thales.Data;
using thales.Models;
using Microsoft.AspNetCore.Mvc;


namespace thales.Controllers
{
    public class ArquivoController : Controller
    {
        readonly private ApplicationDbContext _db;
        public ArquivoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ArquivoModel> thales = _db.Arquivo;
            return View(thales);
        }
    }
}
