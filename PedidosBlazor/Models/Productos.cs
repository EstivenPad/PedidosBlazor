using PedidosBlazor.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazor.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        public string Descripcion { get; set; }

        public double Costo { get; set; }

        public int Inventario { get; set; }
    }
}
