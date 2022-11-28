using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
	public class ProductValidation:AbstractValidator<Product>
	{
		public ProductValidation()
		{
			RuleFor(x => x.CarName).NotEmpty().WithMessage("Product name cant be empty")
										.MinimumLength(3).WithMessage("Product name must be greater than 3")
										.MaximumLength(30).WithMessage("Product name must be less than 30");
		}
	}
}
