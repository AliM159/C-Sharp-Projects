using System;
using Date;
class Program
{
    private static void Main(string[] args)
    {
        DateClass date1 = new DateClass(1, 1, 2022);
        DateClass dateToAdd = new DateClass(50, 14, 3);

        Console.WriteLine(date1.ToString());

        date1.Add(8);
        Console.WriteLine(date1.ToString());


        date1.Add(100, 16);
        Console.WriteLine(date1.ToString());


        date1.Add(dateToAdd);
        Console.WriteLine(date1.ToString());
    }
}
