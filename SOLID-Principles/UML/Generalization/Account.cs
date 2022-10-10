namespace SOLID_Principles.UML.Generalization
{
    class Account
    {
        public int Number { get; set; }

        public string Owner { get; set; }

        public double Balance { get; set; }

        public double Withdraw(double value) 
        { 
            return Balance - value;
        }

        public double Deposit(double value)
        {
            return Balance + value;
        }
    }
}
