namespace SOLID_Principles.DomainModels.Rich
{
    class RichClient
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public RichClient(int id, string name, string address)
        {
            if (id < 0) throw new InvalidOperationException("Invalid id");

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address)) throw new InvalidOperationException();

            Id = id;
            Name = name;
            Address = address;
        }
    }
}
