using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeraAppMVC.Clases;
using PrimeraAppMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PrimeraAppMVC.Controllers
{
    public class MedicamentoController : Controller
    {
        public List<SelectListItem> listaForma()
        {
            List<SelectListItem> listaformafarma = new List<SelectListItem>();
            using (BDHospitalContext db = new BDHospitalContext())
            {
                listaformafarma = (from listafarma in db.FormaFarmaceutica
                                   where listafarma.Bhabilitado == 1
                                   select new SelectListItem
                                   {
                                       Text = listafarma.Nombre,
                                       Value = listafarma.Iidformafarmaceutica.ToString()
                                   }).ToList();
                listaformafarma.Insert(0, new SelectListItem
                {
                    Text="--Seleccione--",
                    Value=""
                });
                
            }
            return listaformafarma;
        }
        public IActionResult Index(MedicamentoCLS medicamento)
        {
            ViewBag.listaForma = listaForma();
            List<MedicamentoCLS> medicamentoCLs = new List<MedicamentoCLS>();
            using(BDHospitalContext db = new BDHospitalContext())
            {
                if (medicamento.idformafarmaceutica == 0)
                {
                    medicamentoCLs = (from medi in db.Medicamento
                                      join forma in db.FormaFarmaceutica
                                      on medi.Iidformafarmaceutica equals forma.Iidformafarmaceutica
                                      where medi.Bhabilitado == 1
                                      select new MedicamentoCLS
                                      {
                                          idmedicamento = medi.Iidmedicamento,
                                          nombre = medi.Nombre,
                                          precio = (decimal)medi.Precio,
                                          stock = (int)medi.Stock,
                                          nombreFormaFarmaceutica = forma.Nombre
                                      }).ToList();
                }
                else
                {
                    medicamentoCLs = (from medi in db.Medicamento
                                      join forma in db.FormaFarmaceutica
                                      on medi.Iidformafarmaceutica equals forma.Iidformafarmaceutica
                                      where medi.Bhabilitado == 1 && forma.Iidformafarmaceutica == medicamento.idformafarmaceutica
                                      select new MedicamentoCLS
                                      {
                                          idmedicamento = medi.Iidmedicamento,
                                          nombre = medi.Nombre,
                                          precio = (decimal)medi.Precio,
                                          stock = (int)medi.Stock,
                                          nombreFormaFarmaceutica = forma.Nombre
                                      }).ToList();
                }
                
            }
            return View(medicamentoCLs);
        }
    }
}
