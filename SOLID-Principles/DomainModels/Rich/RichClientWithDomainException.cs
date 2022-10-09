namespace SOLID_Principles.DomainModels.Rich
{
    class RichClientWithDomainException
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public RichClientWithDomainException(int id, string name, string address)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id");
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name value");
            DomainExceptionValidation.When(string.IsNullOrEmpty(address), "Invalid address value");

            Id = id;
            Name = name;
            Address = address;
        }
    }
}
