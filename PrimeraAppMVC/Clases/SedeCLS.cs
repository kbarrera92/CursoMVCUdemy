using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppMVC.Clases
{
    public class SedeCLS
    {
        [Display(Name = "Id Sede")]
        public int idsede { get; set; }
        [Display(Name = "Nombre Sede")]
        public string nombresede { get; set; }
        [Display(Name = "Dirección Sede")]
        public string direccionsede { get; set; }
    }
}
