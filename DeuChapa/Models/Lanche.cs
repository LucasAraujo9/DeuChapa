using System.ComponentModel.DataAnnotations;

namespace DeuChapa.Models
{
    public class Lanche
    {
        [Required]
        public int Id_Lanche { get; set; }

        [Required(ErrorMessage = "O lanche precisa de um nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O lanche precisa de um valor!")]
        public decimal Valor { get; set; }

        [Required]
        public Ingredientes Ingredientes { get; set; }


        public Lanche() { }

        public Lanche(int id_Lanche, string nome, decimal valor, Ingredientes ingredientes)
        {
            Id_Lanche = id_Lanche;
            Nome = nome;
            Valor = valor;
            Ingredientes = ingredientes;
        }
    }
}
