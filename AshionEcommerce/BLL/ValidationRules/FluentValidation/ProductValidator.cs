using ENTITY.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Ad alanını boş bırakamazsınız")
                              .MaximumLength(500).WithMessage("Ad alanı 500 karakterden fazla olamaz");
        }
    }
}
