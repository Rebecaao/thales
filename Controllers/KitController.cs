using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using thales.Models;
using thales.Data;

namespace thales.Controllers;


    public class KitController : Controller
    {
      
      
    
        readonly private ApplicationDbContext _db;
        public KitController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<KitModel> thales = _db.Kit;
            return View(thales);
        }
    
    
    }
