namespace SOLID_Principles.Principles.LSP.Cohesive
{
    internal class SavingsAccount : Account
    {
        public override void WithDraw(double value)
        {
            if (Balance > value) Balance -= value;
        }
    }
}
