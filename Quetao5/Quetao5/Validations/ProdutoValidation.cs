using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Questao5.Validations
{
    public class CodigoProdutoValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }

            string codigo = value.ToString()!;

            string pattern = @"^[A-Z]{3}-\d{4}$";

            return Regex.IsMatch(codigo, pattern);
        }
    }
}
