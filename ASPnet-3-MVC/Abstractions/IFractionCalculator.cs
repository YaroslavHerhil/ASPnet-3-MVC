using ASPnet_3_MVC.Models;

namespace ASPnet_3_MVC.Abstractor
{
    public interface IFractionCalculator
    {
        public Fraction Add(Fraction fr1, Fraction fr2);
        public Fraction Substract(Fraction fr1, Fraction fr2);
        public Fraction Divide(Fraction fr1, Fraction fr2);
        public Fraction Multiply(Fraction fr1, Fraction fr2);
    }
}
