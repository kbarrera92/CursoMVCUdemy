using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeraAppMVC.Clases;

namespace PrimeraAppMVC.Controllers
{
    public class PaisController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult PruebaLista()
        {
            List<InstructorCLS> lista = new List<InstructorCLS>();
            InstructorCLS instructorCLS = new InstructorCLS
            {
                nombre = "Kevin",
                apPaterno = "Barrera",
                apMaterno = "Reyes"
            };
            lista.Add(instructorCLS);

            instructorCLS = new InstructorCLS
            {
                nombre = "Felipe",
                apPaterno = "Larios",
                apMaterno = "López"
            };
            lista.Add(instructorCLS);
            return View(lista);
        }
    }
}
