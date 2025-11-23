using System;
using CarObjectModel;
internal class Program
{
    private static void Main(string[] args)
    {
        CarClass car1 = new CarClass("Nissan Skyline R34", 2021, 280, 86000);
        CarClass car2 = new CarClass("Hyundai Elantra", 2025, 147, 31200);
        CarClass car3 = new CarClass("Lamborghini Avantador SVJ", 2023, 770, 700300);
        CarClass car4 = new CarClass("Toyota Hilux", 2013, 158, 11000, false);
        CarClass car5 = new CarClass("Tesla Model X", 2022, 670, 124000);


        Console.WriteLine(car1.ToString());
        Console.WriteLine(car2.ToString());
        Console.WriteLine(car3.ToString());
        Console.WriteLine(car4.ToString());
        Console.WriteLine(car5.ToString());

        

    }
}
