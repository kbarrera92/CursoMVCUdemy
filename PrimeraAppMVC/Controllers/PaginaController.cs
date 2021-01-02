using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeraAppMVC.Clases;
using PrimeraAppMVC.Models;

namespace PrimeraAppMVC.Controllers
{
    public class PaginaController : Controller
    {
        public IActionResult Index(PaginaCLS oPaginaCLS)
        {
            List<PaginaCLS> paginas = new List<PaginaCLS>();
            using(BDHospitalContext db = new BDHospitalContext())
            {
                if (oPaginaCLS.mensaje == null || oPaginaCLS.mensaje=="")
                {
                    paginas = (from pag in db.Pagina
                               where pag.Bhabilitado == 1
                               select new PaginaCLS
                               {
                                   idpagina = pag.Iidpagina,
                                   mensaje = pag.Mensaje,
                                   accion = pag.Accion,
                                   controlador = pag.Controlador
                               }).ToList();
                    ViewBag.mensajePagina = "";
                }
                else
                {
                    paginas = (from pag in db.Pagina
                               where pag.Bhabilitado == 1 && pag.Mensaje.Contains(oPaginaCLS.mensaje)
                               select new PaginaCLS
                               {
                                   idpagina = pag.Iidpagina,
                                   mensaje = pag.Mensaje,
                                   accion = pag.Accion,
                                   controlador = pag.Controlador
                               }).ToList();
                    ViewBag.mensajePagina = oPaginaCLS.mensaje;
                }
                
            }
            return View(paginas);
        }
    }
}
