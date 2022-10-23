namespace SOLID_Principles.Principles.LSP.Cohesive
{
    internal abstract class Account
    {
        public double Balance { get; set; }

        public abstract void WithDraw(double value);
    }
}
