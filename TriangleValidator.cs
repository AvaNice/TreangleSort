using FluentValidation;

namespace TreangleSort
{
    public class TriangleValidator : AbstractValidator<Triangle>
    {
        public TriangleValidator()
        {
            RuleFor(treangle => treangle.Name).NotEmpty();

            RuleFor(treangle => treangle.FirstSide)
                .LessThan(treangle => treangle.SecondSide + treangle.ThirdSide)
                .LessThan(double.MaxValue);

            RuleFor(treangle => treangle.SecondSide)
                .LessThan(treangle => treangle.FirstSide + treangle.ThirdSide)
                .LessThan(double.MaxValue);

            RuleFor(treangle => treangle.ThirdSide)
                .LessThan(treangle => treangle.FirstSide + treangle.SecondSide)
                .LessThan(double.MaxValue);
        }
    }
}
