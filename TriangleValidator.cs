using FluentValidation;

namespace TreangleSort
{
    class TriangleValidator : AbstractValidator<Triangle>
    {
        public TriangleValidator()
        {
            RuleFor(treangle => treangle.Name).NotEmpty();

            RuleFor(treangle => treangle.FirstSide)
                .LessThan(treangle => treangle.SecondSide + treangle.ThirdSide)
                .LessThan(treangle => double.MaxValue);

            RuleFor(treangle => treangle.SecondSide)
                .LessThan(treangle => treangle.FirstSide + treangle.ThirdSide)
                .LessThan(treangle => double.MaxValue);

            RuleFor(treangle => treangle.ThirdSide)
                .LessThan(treangle => treangle.FirstSide + treangle.SecondSide)
                .LessThan(treangle => double.MaxValue);
        }
    }
}
