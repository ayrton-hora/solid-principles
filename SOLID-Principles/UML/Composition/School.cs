namespace SOLID_Principles.UML.Composition
{
    class School : IDisposable
    {
        public string Name { get; set; }

        private List<Department> Departments = new List<Department>();

        public void AddDepartment(string name)
        {
            Departments.Add(new Department(name, this));
        }

        public void Dispose()
        {
            foreach (Department department in Departments) department.Dispose();
        }

        // Anothe way to represent
        //private class Department : IDisposable
        //{
        //    private string Name;

        //    private School School;

        //    internal Department(string name, School school)
        //    {
        //        Name = name;
        //        School = school;
        //    }

        //    public void Dispose()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}