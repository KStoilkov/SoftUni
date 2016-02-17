namespace OnlineShop.Services.CustomValidationAttributes
{
    using Data;
    using System.ComponentModel.DataAnnotations;

    public class ValidateTypeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Type cannot be null.");
            }

            using (var context = new OnlineShopContext())
            {
                var type = context.AdTypes.Find(value);

                if (type == null)
                {
                    return new ValidationResult("Ad Type with Id " + value + " doesn't exist.");
                }
            }

            return ValidationResult.Success;
        }
    }
}