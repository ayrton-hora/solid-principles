namespace SOLID_Principles.Principles.SRP.Cohesive
{
    internal class Logger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
