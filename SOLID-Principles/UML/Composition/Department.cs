namespace SOLID_Principles.UML.Composition
{
    class Department : IDisposable
    {
        private string Name;

        private School School;

        internal Department(string name, School school)
        {
            Name = name;
            School = school;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
