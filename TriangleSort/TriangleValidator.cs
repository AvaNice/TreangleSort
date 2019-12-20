using FluentValidation;

namespace TreangleSort
{
    public class TriangleValidator : AbstractValidator<Triangle>
    {
        public TriangleValidator()
        {
            RuleFor(treangle => treangle.Name).NotEmpty();

            RuleFor(treangle => treangle.FirstSide)
                .GreaterThan(0)
                .LessThan(double.MaxValue)
                .LessThan(treangle => treangle.SecondSide + treangle.ThirdSide);

            RuleFor(treangle => treangle.SecondSide)
                .GreaterThan(0)
                .LessThan(double.MaxValue)
                .LessThan(treangle => treangle.FirstSide + treangle.ThirdSide);

            RuleFor(treangle => treangle.ThirdSide)
                .GreaterThan(0)
                .LessThan(double.MaxValue)
                .LessThan(treangle => treangle.FirstSide + treangle.SecondSide);
                 
        }
    }
}
