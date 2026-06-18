using System.ComponentModel.DataAnnotations;

namespace GerenciamentoFinanceiro.Models
{
    public class Categoria
    {
        public string CategoriaId { get; set; }

        [Required(ErrorMessage = "Digite a Categoria!")]
        public string Nome { get; set; }
    }
}
