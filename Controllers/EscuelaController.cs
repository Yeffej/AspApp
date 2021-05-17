using Microsoft.AspNetCore.Mvc;
using ASPnet_Course.Models;
using System;

namespace ASPnet_Course.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index() {
            Escuela escuela = new Escuela();
            escuela.Nombre = "Hight YeffSchool";
            escuela.Dirección = "República Dominicana";
            escuela.AñoDeCreación = 2013;
            return View(escuela);
        }
    }
}