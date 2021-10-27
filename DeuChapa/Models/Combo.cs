using System.ComponentModel.DataAnnotations;

namespace DeuChapa.Models
{
    public class Combo
    {
        [Required]
        public int Id_Combo { get; set; }

        [Required]
        public Lanche Lanche { get; set; }

        [Required]
        public Bebida Bebida { get; set; }

        [Required]
        public decimal Valor { get; set; }

        public Combo() { }
    }
}