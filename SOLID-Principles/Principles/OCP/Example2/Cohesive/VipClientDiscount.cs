namespace SOLID_Principles.Principles.OCP.Example2.Cohesive
{
    internal class VipClientDiscount : Request
    {
        public override double Discount(double finalValue)
        {
            return finalValue - 50;
        }
    }
}
