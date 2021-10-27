using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeuChapa.Models
{
    public class Ingredientes
    {
        public int Id_Ingrediente { get; set; }

        [Required(ErrorMessage ="O lanche precisa ter um tipo de pão")]
        public string Pao { get; set; }

        [Required(ErrorMessage = "O lanche precisa ter hamgurguer")]
        public string Hamburguer { get; set; }
        public string Queijo { get; set; }
        public string Molho { get; set; }
        public bool Tomate { get; set; }
        public bool Alface { get; set; }

        [NotMapped]
        public string _Alface { get; set; }
        [NotMapped]
        public string _Tomate { get; set; }


        public Ingredientes()
        {
        }

        public Ingredientes(int id_Ingrediente, string pao, string hamburguer, string queijo, string molho, bool tomate, bool alface)
        {
            Id_Ingrediente = id_Ingrediente;
            Pao = pao;
            Hamburguer = hamburguer;
            Queijo = queijo;
            Molho = molho;
            Tomate = tomate;
            Alface = alface;
        }
    }
}
