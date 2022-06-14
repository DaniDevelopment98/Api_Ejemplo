using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace api_Ejemplo.Models
{
    public class Clientes
    {
        [Key]
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string telefono { get; set; }
    }
}
