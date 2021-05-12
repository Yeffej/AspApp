using Microsoft.AspNetCore.Mvc;
using ASPnet_Course.Models;
using System;

namespace ASPnet_Course.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult index() {
            Escuela escuela = new Escuela();
            escuela.ID = Guid.NewGuid().ToString();
            escuela.Name = "Hight YeffSchool";
            escuela.Direction = "República Dominicana";
            escuela.annoFoundation = 2013;
            return View(escuela);
        }
    }
}