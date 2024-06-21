using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base you want to convert from: ");
        int baseFrom = int.Parse(Console.ReadLine());
        Console.Write("Enter the base you want to convert to: ");
        int baseTo = int.Parse(Console.ReadLine());
        Console.Write("Enter the number: ");
        string number = Console.ReadLine();

        string convertedNumber = ConvertNumber(baseFrom, baseTo, number);
        Console.WriteLine("Converted number: " + convertedNumber);
    }

    static string ConvertNumber(int baseFrom, int baseTo, string number)
    {
        int decimalNumber = Convert.ToInt32(number, baseFrom);
        return Convert.ToString(decimalNumber, baseTo);
    }
}
