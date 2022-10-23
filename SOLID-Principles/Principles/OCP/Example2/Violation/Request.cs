namespace SOLID_Principles.Principles.OCP.Example2.Violation
{
    public enum ClientType
    {
        Common,
        Associated,
        Vip
    }

    internal class Request
    {
        // To do

        public double Discount(double value, ClientType clientType)
        {
            double finalValue;

            if (clientType == ClientType.Vip) finalValue = value - 50;

            else if (clientType == ClientType.Associated) finalValue = value - 10;

            else finalValue = value;

            return finalValue;
        }
    }
}
