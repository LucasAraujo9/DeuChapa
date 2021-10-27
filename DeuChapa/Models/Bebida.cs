using System.ComponentModel.DataAnnotations;

namespace DeuChapa.Models
{
    public class Bebida
    {
        [Required]
        public int Id_Bebida { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "A bebida precisa de um nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A bebida precisa de um valor!")]
        public decimal Valor { get; set; }

        public Bebida(){}

        public Bebida(int id_Bebida, string nome, string tipo, decimal valor)
        {
            Id_Bebida = id_Bebida;
            Nome = nome;
            Tipo = tipo;
            Valor = valor;
        }
    }
}
