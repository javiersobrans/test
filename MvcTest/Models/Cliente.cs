using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcTest.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Teléfono movil")]
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public DateTime Creado { get; set; }

    }
}
