using ASPnet_3_MVC.Models;

namespace ASPnet_3_MVC.Calculations
{
    public static class FractionCalculator
    {
        public static Fraction Add(Fraction a, Fraction b) =>
            new Fraction()
            {
                Numenator = a.Numenator * b.Denominator + b.Numenator * a.Denominator,
                Denominator = a.Denominator * b.Denominator,
            };

        public static Fraction Substract(Fraction a, Fraction b) =>
            new Fraction()
            {
                Numenator = a.Numenator * b.Denominator - b.Numenator * a.Denominator,
                Denominator = a.Denominator * b.Denominator,
            };

        public static Fraction Multiply(Fraction a, Fraction b) =>
            new Fraction()
            {
                Numenator = a.Numenator * b.Numenator,
                Denominator = b.Numenator * b.Denominator,
            };

        public static Fraction Divide(Fraction a, Fraction b) =>
            Multiply(a, new Fraction()
            {
                Numenator = b.Denominator,
                Denominator = b.Numenator,
            });
    }
}
