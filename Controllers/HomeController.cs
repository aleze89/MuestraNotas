using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notes.Models;

namespace Notes.Controllers
{
     public class TestController : Controller
    {
        public readonly NotasContext db;
        public TestController(NotasContext context)
        {
            db = context;
        }
    

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

         public JsonResult ConsultarNotas()
        {
            return Json(db.Notas);
        }

        public string CrearNota(string titulo, string texto)
        {
            Nota nuevaNota = new Nota{
                Titulo = titulo,
                Cuerpo = texto
            };

            db.Notas.Add(nuevaNota);
            db.SaveChanges();
            return "Ok!!";
        }

   
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
   }

}
