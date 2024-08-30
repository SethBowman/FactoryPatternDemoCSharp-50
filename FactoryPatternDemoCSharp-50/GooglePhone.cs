namespace FactoryPatternDemoCSharp_50;

public class GooglePhone : IMobilePhone
{
    public int Number { get; set; }
    public void Call()
    {
        Console.WriteLine("Calling with a Google phone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with a Google phone..");
    }
}