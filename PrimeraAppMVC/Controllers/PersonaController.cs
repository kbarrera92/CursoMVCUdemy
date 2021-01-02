using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using PrimeraAppMVC.Models;
using PrimeraAppMVC.Clases;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PrimeraAppMVC.Controllers
{
    public class PersonaController : Controller
    {
        public void llenarSexo()
        {
            List<SelectListItem> listaSexo = new List<SelectListItem>();
            using(BDHospitalContext db = new BDHospitalContext())
            {
                listaSexo = (from sexo in db.Sexo
                             where sexo.Bhabilitado == 1
                             select new SelectListItem
                             {
                                 Text = sexo.Nombre,
                                 Value = sexo.Iidsexo.ToString()
                             }).ToList();
                listaSexo.Insert(0, new SelectListItem
                {
                    Text = "--Selecciona--",
                    Value = ""
                });
            }
            ViewBag.listaSexo = listaSexo;
        }
        public IActionResult Index(PersonaCLS oPersonaCLS)
        {
            List<PersonaCLS> listaPersona = new List<PersonaCLS>();
            llenarSexo();
            using (BDHospitalContext db = new BDHospitalContext())
            {
                if(oPersonaCLS.idsexo == 0)
                {
                    listaPersona = (from persona in db.Persona
                                    join sexo in db.Sexo
                                    on persona.Iidsexo equals sexo.Iidsexo
                                    where persona.Bhabilitado == 1
                                    select new PersonaCLS
                                    {
                                        idpersona = persona.Iidpersona,
                                        nombreCompleto = persona.Nombre + " " + persona.Appaterno + " " + persona.Apmaterno,
                                        email = persona.Email,
                                        nombreSexo = sexo.Nombre
                                    }).ToList();
                } else
                {
                    listaPersona = (from persona in db.Persona
                                    join sexo in db.Sexo
                                    on persona.Iidsexo equals sexo.Iidsexo
                                    where persona.Bhabilitado == 1 && persona.Iidsexo == oPersonaCLS.idsexo
                                    select new PersonaCLS
                                    {
                                        idpersona = persona.Iidpersona,
                                        nombreCompleto = persona.Nombre + " " + persona.Appaterno + " " + persona.Apmaterno,
                                        email = persona.Email,
                                        nombreSexo = sexo.Nombre
                                    }).ToList();
                }
                
            }
            return View(listaPersona);
        }
    }
}
