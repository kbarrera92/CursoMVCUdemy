using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppMVC.Clases
{
    public class PaginaCLS
    {
        [Display(Name = "Id Página")]
        public int idpagina { get; set; }
        [Display(Name = "Mensaje")]
        public string mensaje { get; set; }
        [Display(Name = "Acción")]
        public string accion { get; set; }
        [Display(Name = "Controlador")]
        public string controlador { get; set; }
    }
}
