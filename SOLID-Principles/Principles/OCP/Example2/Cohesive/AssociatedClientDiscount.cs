namespace SOLID_Principles.Principles.OCP.Example2.Cohesive
{
    internal class AssociatedClientDiscount : Request
    {
        public override double Discount(double finalValue)
        {
            return finalValue - 10;
        }
    }
}
