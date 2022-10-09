using SOLID_Principles.ExtensionMethods;
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

void StringExtension()
{
    string text1 = "first text";
    string text2 = "second text";
    string text3 = "";

    text1 = text1.UpperStringFirstLetter();
    text2 = text2.UpperStringFirstLetter();
    text3 = text3.UpperStringFirstLetter();

    Console.WriteLine($"New Text 1: {text1}");
    Console.WriteLine($"New Text 2: {text2}");
    Console.WriteLine($"New Text 3: {text3}");
}

// Main

// Domain Models
// AnemicClient();
// RichClient();
// RichClientWithDomainException();

// ExtensionMethods
StringExtension();
