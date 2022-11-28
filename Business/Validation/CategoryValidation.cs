using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
	public class CategoryValidation:AbstractValidator<Category>
	{
		public CategoryValidation()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name cant be empty")
										.MinimumLength(3).WithMessage("Category name must be greater than 3")
										.MaximumLength(30).WithMessage("Category name must be less than 30");
		}
	}
}
