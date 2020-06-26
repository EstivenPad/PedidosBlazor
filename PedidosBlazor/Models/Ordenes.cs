using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazor.Models
{
    public class Ordenes
    {
        [Key]
        public int OrdenId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int SuplidorId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Monto { get; set; }

        [ForeignKey("OrdenId")]
        public virtual List<OrdenesDetalle> OrdenesDetalle { get; set; } = new List<OrdenesDetalle>();
    }
}
