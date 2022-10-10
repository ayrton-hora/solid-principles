namespace SOLID_Principles.UML.CompositionVSGeneralization.LowCoupling
{
    class Cat
    {
        Animal cat = new();

        WalkBehavior walk = new();

        public void Meow()
        {
            Console.WriteLine("Meowww...");
        }
    }
}
