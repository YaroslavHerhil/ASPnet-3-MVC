namespace ASPnet_3_MVC.Models
{
    public class Fraction
    {
        public int Numenator {  get; set; }
        public int Denominator { get; set; }

        public string ToDecimalString() => ((double)(Numenator) / Denominator).ToString("0.##");

        public override string ToString() => $"{Numenator}/{Denominator}";
        public Fraction() { }
        public Fraction(int n, int d) { Numenator = n; Denominator = d; }
    }
}
