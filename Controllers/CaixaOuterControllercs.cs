using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using thales.Models;
namespace thales.Controllers;

    public class CaixaOuterControllers : Controller
    {
           public IActionResult Index()
    {
        return View();
    }
    }
