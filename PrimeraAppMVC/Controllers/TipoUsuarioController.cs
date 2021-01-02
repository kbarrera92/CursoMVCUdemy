using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeraAppMVC.Models;
using PrimeraAppMVC.Clases;

namespace PrimeraAppMVC.Controllers
{
    public class TipoUsuarioController : Controller
    {
        public IActionResult Index(TipoUsuarioCLS oTipoUsuarioCLS)
        {
            List<TipoUsuarioCLS> tipoUsuarioCLs = new List<TipoUsuarioCLS>();
            using(BDHospitalContext db = new BDHospitalContext())
            {
                tipoUsuarioCLs = (from tipo in db.TipoUsuario
                                  where tipo.Bhabilitado == 1
                                  select new TipoUsuarioCLS
                                  {
                                      idusuario = tipo.Iidtipousuario,
                                      nombreusuario = tipo.Nombre,
                                      descripcion = tipo.Descripcion
                                  }).ToList();
                if(oTipoUsuarioCLS.idusuario==0 && oTipoUsuarioCLS.nombreusuario==null && oTipoUsuarioCLS.descripcion==null)
                {
                    ViewBag.Nombre = "";
                    ViewBag.Descripcion = "";
                    ViewBag.IdTipoUsuario = 0;
                }
                else
                {
                    if (oTipoUsuarioCLS.idusuario!=0)
                    {
                        tipoUsuarioCLs = tipoUsuarioCLs.Where(x => x.idusuario == oTipoUsuarioCLS.idusuario).ToList();
                    }
                    if (oTipoUsuarioCLS.nombreusuario != null)
                    {
                        tipoUsuarioCLs = tipoUsuarioCLs.Where(x => x.nombreusuario.Contains(oTipoUsuarioCLS.nombreusuario)).ToList();
                    }
                    if (oTipoUsuarioCLS.descripcion != null)
                    {
                        tipoUsuarioCLs = tipoUsuarioCLs.Where(x => x.descripcion.Contains(oTipoUsuarioCLS.descripcion)).ToList();
                    }
                    ViewBag.Nombre = oTipoUsuarioCLS.nombreusuario;
                    ViewBag.Descripcion = oTipoUsuarioCLS.descripcion;
                    ViewBag.IdTipoUsuario = oTipoUsuarioCLS.idusuario;
                }
            }
            return View(tipoUsuarioCLs);
        }
    }
}
