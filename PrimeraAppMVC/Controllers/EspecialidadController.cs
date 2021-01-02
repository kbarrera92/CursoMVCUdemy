using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeraAppMVC.Models;
using PrimeraAppMVC.Clases;

namespace PrimeraAppMVC.Controllers
{
    public class EspecialidadController : Controller
    {
        public IActionResult Index(EspecialidadCLS especialidadCls)
        {
            List<EspecialidadCLS> lista = new List<EspecialidadCLS>();
            using (BDHospitalContext db = new BDHospitalContext())
            {
                if (especialidadCls.nombre == null || especialidadCls.nombre == "")
                {
                    lista = (from especialidad in db.Especialidad
                             where especialidad.Bhabilitado == 1
                             select new EspecialidadCLS
                             {
                                 idespecialidad = especialidad.Iidespecialidad,
                                 nombre = especialidad.Nombre,
                                 descripcion = especialidad.Descripcion
                             }).ToList();
                }
                else
                {
                    lista = (from especialidad in db.Especialidad
                             where especialidad.Bhabilitado == 1 && especialidad.Nombre.Contains(especialidadCls.nombre)
                             select new EspecialidadCLS
                             {
                                 idespecialidad = especialidad.Iidespecialidad,
                                 nombre = especialidad.Nombre,
                                 descripcion = especialidad.Descripcion
                             }).ToList();
                    ViewBag.nombreEspecialidad = especialidadCls.nombre;
                }
                return View(lista);
            }
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(EspecialidadCLS oEspecialidadCLS)
        {
            try
            {
                using(BDHospitalContext db = new BDHospitalContext())
                {
                    if (!ModelState.IsValid)
                    {
                        return View(oEspecialidadCLS);
                    }
                    else
                    {
                        Especialidad objeto = new Especialidad
                        {
                            Nombre = oEspecialidadCLS.nombre,
                            Descripcion = oEspecialidadCLS.descripcion,
                            Bhabilitado = 1
                        };
                        db.Especialidad.Add(objeto);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                return View(oEspecialidadCLS);
            }

            return RedirectToAction("Index");
        }
    }
}
