using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppMVC.Clases
{
    public class MedicamentoCLS
    {
        [Display(Name ="Id Medicamento")]
        public int idmedicamento { get; set; }
        [Display(Name = "Nombre Medicamento")]
        public string nombre { get; set; }
        [Display(Name = "Precio Medicamento")]
        public decimal precio { get; set; }
        [Display(Name = "Existencia")]
        public int stock { get; set; }
        [Display(Name = "Forma Farmaceutica")]
        public string nombreFormaFarmaceutica { get; set; }
        public int idformafarmaceutica { get; set; }
    }
}
