using Microsoft.AspNetCore.Mvc;
using ASPnet_Course.Models;
using System.Collections.Generic;

namespace ASPnet_Course.Controllers {
    public class AsignaturaController: Controller {
        public IActionResult Index() {
           Asignatura main = new Asignatura{Nombre="Fundamentos de la ingeniería de software"};
            return View(main);
        }
        public IActionResult All() {
            List<Asignatura> asignaturas = new List<Asignatura> {
                new Asignatura{Nombre="Matemáticas"},
                new Asignatura{Nombre="Programación Avanzada"},
                new Asignatura{Nombre="Ciencias de Datos"},
                new Asignatura{Nombre="Ciencias de Naturales"},
                new Asignatura{Nombre="Introducción a la probabilidad"},
            };
            
            return View(asignaturas);
        }
    }
}