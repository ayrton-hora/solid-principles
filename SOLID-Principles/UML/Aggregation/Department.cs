namespace SOLID_Principles.UML.Aggregation
{
    class Department : IDisposable
    {
        public string Name { get; set; }

        public List<Teacher> Teachers { get; set; }

        public void Dispose() { }
    }
}
