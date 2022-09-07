using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = InputName();
        string number = InputNumber();
        string owner = InputOwner();
        string value = InputValue();
        PrintInputInformation(name, number, owner, value);

        ExchangeMoney.Exchange();
    }

    public static string InputName()
    {
        Console.Write("Please input Name : ");
        return Console.ReadLine();
    }

    public static string InputNumber()
    {
        Console.Write("Please input Number : ");
        return Console.ReadLine();
    }

    public static string InputOwner()
    {
        Console.Write("Please input Owner Name : ");
        return Console.ReadLine();
    }

    public static string InputValue()
    {
        Console.Write("Please input Registered Value : ");
        return Console.ReadLine();
    }

    public static void PrintInputInformation(string name, string number, string owner, string value)
    {
        Console.WriteLine("\n----------- Shop Information -----------");
        Console.WriteLine("\nName : {0}",name);
        Console.WriteLine("Number : {0}",number);
        Console.WriteLine("Owner Name : {0}",owner);
        Console.WriteLine("Registered Value : {0}",value);
        Console.WriteLine("\n----------------------------------------");
    }
}