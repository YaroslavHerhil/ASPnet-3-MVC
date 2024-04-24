using ASPnet_3_MVC.Abstractor;
using ASPnet_3_MVC.Calculations;
using ASPnet_3_MVC.Models;

namespace ASPnet_3_MVC.Services
{
    public class FractionService : IFractionService
    {

        public bool Calculate(FractionOperationViewModel model)
        {
            switch (model.Operation)
            {
                case "+":
                    model.Result = FractionCalculator.Add(model.Fraction1, model.Fraction2).ToString();
                    return true;
                case "-":
                    model.Result = FractionCalculator.Substract(model.Fraction1, model.Fraction2).ToString();
                    return true;
                case "*":
                    model.Result = FractionCalculator.Multiply(model.Fraction1, model.Fraction2).ToString();
                    return true;
                case "/":
                    model.Result = FractionCalculator.Divide(model.Fraction1, model.Fraction2).ToString();
                    return true;
                default:
                    model.Result = null;
                    return false;

            }
        }

        
    }

}
