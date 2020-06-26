using PedidosBlazor.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazor.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int SuplidorId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Costo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Inventario { get; set; }
    }
}
