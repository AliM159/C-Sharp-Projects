using System;
using Pets;

class Program
{


    //public static void ListPets(List<Pet> pets)
    //{
    //    Console.Write("Enter the owner's name: ");
    //    string owner = Console.ReadLine();

    //    int count = 1;

    //    foreach (Pet p1 in pets)
    //    {

    //        if (p1.Owner == owner)
    //        {

    //            Console.WriteLine($"{count}. {p1}");
    //            Console.WriteLine();
    //            Console.WriteLine();
    //            count++;
    //        }
    //    }


    //}




    private static void Main(string[] args)
    {
        Pet pet1 = new Pet("Iggy", 3, "Stand-User Dog");

        Pet pet2 = new Pet("Gamabunta", 100, "Sage Frog"); // set owner method

        Pet pet3 = new Pet("Tony Tony Chopper", 17, "Devil Fruit User Reindeer");

        Pet pet4 = new Pet("Pikachu", 4, "Squirrel Pokemon"); // train method & set owner

        Pet pet5 = new Pet("Kurama", 200, "Tailed Beast Fox"); // set owner method

        pet2.Train();
        pet2.SetOwner("Naruto");
        pet4.Train();
        pet4.SetOwner("Ash");
        pet5.SetOwner("Naruto");


        List<Pet> pets = new List<Pet>() { pet1, pet2, pet3, pet4, pet5 };


        foreach (Pet p in pets)
        {
            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine("__________________________");
        }



        Console.WriteLine();
        Console.WriteLine();



        Console.Write("Enter the owner's name: ");
        string owner = Console.ReadLine();


        int count = 1;
        foreach (Pet p in pets)
        {

            if (p.Owner == owner)
            {

                Console.WriteLine($"{count}. {p}");
                Console.WriteLine();
                Console.WriteLine();
                count++;
            }
        }



        //int choice = 1;
        //while (choice == 1)

        //{
        //    ListPets(pets);
        //    Console.WriteLine("Do you want to continue?");
        //    Console.WriteLine("[(1) to continue, (0) to exit]");
        //    choice = Convert.ToInt32(Console.ReadLine());
        //}

    }




                    
}