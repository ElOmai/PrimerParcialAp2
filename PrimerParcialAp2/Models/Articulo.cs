using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAp2.Models
{
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage = "Se requiere una fecha")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Se requiere la descripcion del articulo")]
        public string Descripcion { get; set; }
        [Range(0, 1000000, ErrorMessage = "El costo debe estar entre 1 y 1,000,000")]
        public decimal Costo { get; set; }
        [Range(0, 1000, ErrorMessage = "El porcentaje de gananciadebe estar entre 1 y 1000")]
        public int PorcentajeGanancia { get; set; }

        public void articulo()
        {
            ArticuloId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            PorcentajeGanancia = 0;
        }
    }
}
