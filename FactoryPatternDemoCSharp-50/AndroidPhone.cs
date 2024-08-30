namespace FactoryPatternDemoCSharp_50;

public class AndroidPhone : IMobilePhone
{
    public int Number { get; set; }
    public void Call()
    {
        Console.WriteLine("Calling with an Android phone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with an Android phone..");
    }
}