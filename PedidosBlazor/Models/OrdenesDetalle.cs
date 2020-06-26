using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazor.Models
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int OrdenId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Costo { get; set; }
    }
}
