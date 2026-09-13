using System.ComponentModel.DataAnnotations;

namespace DevWeb1.Validations
{
    public class IdadeValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int valor = Convert.ToInt32(value);
            if (valor < 18)
            {
                return false;
            }
            return true;
        }
    }
}