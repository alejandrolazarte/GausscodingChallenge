using FluentValidation;

namespace Application.Product.Commands.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.BrandId)
                .GreaterThan(0)
                .WithMessage("Test BrandId not be less than or equal to 0.");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name should not be empty.")
                .MaximumLength(250)
                .WithMessage("Name must not exceed 250 characters.");

            RuleFor(x => x).Must(x => x.Price > x.Cost)
                .WithMessage("the price cannot be less than the cost");
        }
    }
}
