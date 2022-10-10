namespace SOLID_Principles.UML.Generalization
{
    class CheckingAccount : Account
    {
        public double Limit { get; set; }

        public double Tax(double taxValue)
        {
            return Balance - taxValue;
        }
    }
}
