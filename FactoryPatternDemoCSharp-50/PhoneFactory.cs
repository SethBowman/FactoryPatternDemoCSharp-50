namespace FactoryPatternDemoCSharp_50;

public static class PhoneFactory
{
    public static IMobilePhone BuildPhone(string phoneType)
    {
        switch (phoneType.ToLower())
        {
            case "apple":
            case "iphone":
                return new ApplePhone();
            case "android":
                return new AndroidPhone();
            case "google":
                return new GooglePhone();
            default:
                return new AndroidPhone();
        }
    }
}