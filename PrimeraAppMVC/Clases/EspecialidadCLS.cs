using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppMVC.Clases
{
    public class EspecialidadCLS
    {
        [Display(Name = "Id Especialidad")]
        public int idespecialidad { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Nombre Especialidad")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Descripción Especialidad")]
        public string descripcion { get; set; }
    }
}
