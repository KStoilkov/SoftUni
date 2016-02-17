namespace OnlineShop.Services.CustomValidationAttributes
{
    using Data;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class ValidateAdAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Categories are missing.");
            }

            List<int> categories = value as List<int>;
            if (categories.Count < 1 && categories.Count > 3)
            {
                return new ValidationResult("Categories should be at least 1 and no more than 3.");
            }

            using (var context = new OnlineShopContext())
            {
                var DbCategories = context.Categories
                    .Select(c => c.Id);

                foreach (var categoryId in categories)
                {
                    if (!DbCategories.Contains(categoryId))
                    {
                        return new ValidationResult("Category with Id " + categoryId + " doesn't exist.");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}