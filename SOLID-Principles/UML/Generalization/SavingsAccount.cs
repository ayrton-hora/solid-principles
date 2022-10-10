namespace SOLID_Principles.UML.Generalization
{
    class SavingsAccount : Account
    {
        public DateTime BirthdayDate { get; set; }

        public double Credit(double creditValue)
        {
            return Balance + creditValue;
        }
    }
}
