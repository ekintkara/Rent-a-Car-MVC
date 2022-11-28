using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class ModelValidation:AbstractValidator<Model>
    {
        public ModelValidation()
        {
            RuleFor(x => x.ModelName).NotEmpty().WithMessage("ModelName name cant be empty")
                                        .MinimumLength(3).WithMessage("ModelName name must be greater than 3")
                                        .MaximumLength(30).WithMessage("ModelName name must be less than 30");
        }
    }
}
