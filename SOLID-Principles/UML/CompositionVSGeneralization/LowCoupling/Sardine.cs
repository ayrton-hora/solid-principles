namespace SOLID_Principles.UML.CompositionVSGeneralization.LowCoupling
{
    class Sardine
    {
        Animal sardine = new();

        SwimBehavior swim = new();
    }
}
