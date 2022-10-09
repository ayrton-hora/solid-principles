using SOLID_Principles.DomainModels.Rich;
using SOLID_Principles.DomainModels.Anemic;

void AnemicClient()
{
    AnemicClient client = new()
    {
        Id = -1,
        Name = "Joe",
        Address = "Some address"
    };

    Console.WriteLine($"AnemicClient:\nId: {client.Id}\n" +
        $"Name: {client.Name}\n" +
        $"Address: {client.Address}\n");
}

void RichClient()
{
    RichClient client = new(1, "Joseph", "Some address");

    Console.WriteLine($"RichClient:\nId: {client.Id}\n" +
        $"Name: {client.Name}\n" +
        $"Address: {client.Address}\n");
}

void RichClientWithDomainException()
{
    RichClientWithDomainException client = new(-1, "Joseph", "Some address");

    Console.WriteLine($"RichClientWithDomainException:\nId: {client.Id}\n" +
        $"Name: {client.Name}\n" +
        $"Address: {client.Address}\n");
}


AnemicClient();
RichClient();
RichClientWithDomainException();
