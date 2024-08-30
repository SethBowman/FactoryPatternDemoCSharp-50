using FactoryPatternDemoCSharp_50;

Console.WriteLine("What type of phone do you have?");
var userInput = Console.ReadLine();
var phone = PhoneFactory.BuildPhone(userInput);
phone.Call();
phone.Text();