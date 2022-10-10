namespace SOLID_Principles.UML.CompositionVSGeneralization.LowCoupling
{
    class Human
    {
        Animal human = new();

        WalkBehavior walk = new();

        public void Hello()
        {
            Console.WriteLine("Hello...");
        }
    }
}
