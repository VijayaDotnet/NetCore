using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SignUpValidation.Attributes
{
    public class CheckboxValidation : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-checkbox", ErrorMessage);
        }

        public override bool IsValid(object? value)
        {
            if (value != null && (bool)value == true)
                return true;
            else

                return false;

        }
    }
}
