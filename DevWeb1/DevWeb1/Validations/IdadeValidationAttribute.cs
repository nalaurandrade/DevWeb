using System;
using System.ComponentModel.DataAnnotations;

namespace DevWeb1.Validations
{
    public class IdadeValidationAttribute : ValidationAttribute
    {
        private readonly int _min;
        private readonly int _max;

        public IdadeValidationAttribute(int min = 0, int max = 120)
        {
            _min = min;
            _max = max;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult(ErrorMessage ?? "Idade é obrigatória.");

            if (!int.TryParse(value.ToString(), out var idade))
                return new ValidationResult(ErrorMessage ?? "Idade inválida.");

            if (idade < _min || idade > _max)
                return new ValidationResult(ErrorMessage ?? $"Idade deve estar entre {_min} e {_max}.");

            return ValidationResult.Success;
        }
    }
}