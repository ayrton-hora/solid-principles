namespace SOLID_Principles.Principles.LSP.Violation
{
    internal class Account
    {
        public double Balance { get; set; }

        public virtual void WithDraw(double value)
        {
            Balance -= value;
        }
    }
}
