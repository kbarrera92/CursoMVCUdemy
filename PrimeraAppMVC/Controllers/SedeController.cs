using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeraAppMVC.Clases;
using PrimeraAppMVC.Models;

namespace PrimeraAppMVC.Controllers
{
    public class SedeController : Controller
    {
        public IActionResult Index(SedeCLS oSedeCls)
        {
            List<SedeCLS> sedes = new List<SedeCLS>();
            using (BDHospitalContext db = new BDHospitalContext())
            {
                if (oSedeCls.nombresede == "" || oSedeCls.nombresede == null)
                {
                    sedes = (from sede in db.Sede
                             where sede.Bhabilitado == 1
                             select new SedeCLS
                             {
                                 idsede = sede.Iidsede,
                                 nombresede = sede.Nombre,
                                 direccionsede = sede.Direccion
                             }).ToList();
                    ViewBag.nombreSede = "";
                }
                else
                {
                    sedes = (from sede in db.Sede
                             where sede.Bhabilitado == 1 && sede.Nombre.Contains(oSedeCls.nombresede)
                             select new SedeCLS
                             {
                                 idsede = sede.Iidsede,
                                 nombresede = sede.Nombre,
                                 direccionsede = sede.Direccion
                             }).ToList();
                    ViewBag.nombreSede = oSedeCls.nombresede;
                }
            }
            return View(sedes);
        }
    }
}
