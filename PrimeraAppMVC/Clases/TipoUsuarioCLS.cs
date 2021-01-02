using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace PrimeraAppMVC.Clases
{
    public class TipoUsuarioCLS
    {
        [Display(Name ="Id Tipo")]
        public int idusuario { get; set; }
        [Display(Name = "Nombre Usuario")]
        public string nombreusuario { get; set; }
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
    }
}
