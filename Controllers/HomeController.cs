﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notes.Models;

namespace Notes.Controllers
{
   
    

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly NotasContext db;

        public HomeController(ILogger<HomeController> logger,
        NotasContext contexto)
        {
            this.logger = logger;
            this.db = contexto;
        }

        public IActionResult Index()
        {
            return View(db.Notas.ToList());
        }

        public IActionResult CargarNotas()
        {
            return View();
        }

        public IActionResult CargarUsuarios()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public JsonResult ConsultarNotas()
        {
            return Json(db.Notas.ToList());
        }

        [HttpPost]
        public JsonResult CrearNota(string titulo, string texto)
        {
            Nota nuevaNota = new Nota{
                Titulo = titulo,
                Cuerpo = texto
            };

            db.Notas.Add(nuevaNota);
            db.SaveChanges();
            return Json(nuevaNota);
        }

        [HttpPost]
         public JsonResult AgregarUsuarioASession(string mail, string nombre)
        {
            Usuario nuevoUsuario = new Usuario{
                Mail= mail,
                Nombre = nombre
                
            };
            HttpContext.Session.Set<Usuario>("UsuarioLogueado", nuevoUsuario);
            return Json(nuevoUsuario);
        }
     
        public JsonResult ConsultarUsuario()
        {
            var usuario = HttpContext.Session.Get<Usuario>("UsuarioLogueado");
            if(usuario != null)
            {
                return Json(usuario);
            }
            else
            {
                return Json("No está logueado");
            }

        }

   
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
   

}
