using DevWeb1.Validations;
using System.ComponentModel.DataAnnotations;

namespace DevWeb1.Models
{
    public class Aluno
    {
        //if (string.IsNullOrEmpty(aluno.Nome))
        //   return BadRequest("Nome do aluno é obrigatório");
        [StringLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
        [StringLength(6, ErrorMessage = "O RA deve ter, no máximo, 6 dígitos, variando de 0 a 9")]
        [Required(ErrorMessage = "RA deve começar com as letras RA")]
        public string RA { get; set; }
        [Required(ErrorMessage = "Cpf é obrigatório")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Cadastro inativo")]
        public string Ativo { get; set; }

    }
}
