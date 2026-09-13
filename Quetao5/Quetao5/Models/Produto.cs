using System.ComponentModel.DataAnnotations;
using Questao5.Validations;

namespace Questao5.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "O código do produto é obrigatório")]
        [CodigoProdutoValidation(ErrorMessage = "O código deve seguir o formato 'AAA-1234' (3 letras maiúsculas, hífen e 4 números)")]
        public string CodigoProduto { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O estoque é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo")]
        public int Estoque { get; set; }
    }
}
