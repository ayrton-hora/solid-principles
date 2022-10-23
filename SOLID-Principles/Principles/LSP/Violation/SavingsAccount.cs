namespace SOLID_Principles.Principles.LSP.Violation
{
    internal class SavingsAccount : Account
    {
        // External different behavior
        public override void WithDraw(double value)
        {
            if (Balance > value) Balance -= value;
        }
    }
}
