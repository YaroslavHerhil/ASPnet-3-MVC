using Microsoft.Build.Evaluation;

namespace ASPnet_3_MVC.Models
{
    public class FractionOperationViewModel
    {
        public Fraction Fraction1 { get; set; }
        public Fraction Fraction2 { get; set; }
        public string Operation { get; set; }
        public string Result { get; set; } 

        public FractionOperationViewModel()
        {
            Fraction1 = new Fraction();
            Fraction2 = new Fraction();
        }

    }
}
