using FluentValidation;
namespace FluentModelValidation.Models.Filter
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.ID).NotNull().WithMessage("Id can't be null.");
            RuleFor(x => x.Name).Length(0, 5).WithMessage("Name length can't be greater than 5.");
        }
    }
}