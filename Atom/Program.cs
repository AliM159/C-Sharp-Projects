using System;
using Atoms;
using System.IO;
using System.Text.Json;

class Program
{
    static private void Main(string[] args)
    {
        string filename = "C:\\Users\\alihu\\OneDrive\\Desktop\\S2\\COMP123\\Assignments\\assign04\\Atom\\atoms.json";

        List<Atom> atoms = Atom.GetAtoms();


        WriteJson(atoms, filename);

        ReadJson(filename);
    }


    static void WriteJson (List<Atom> atom, string filename)
    {
        string jsonString = JsonSerializer.Serialize(atom, new JsonSerializerOptions { WriteIndented = true});
        File.WriteAllText(filename, jsonString);
        Console.WriteLine("Atoms List saved Successfully !!!");
    }


    static void ReadJson(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found");
        }

        else
        {
            Console.WriteLine("<---------Atoms in File--------->");
            Console.WriteLine();
            string jsonFromFile = File.ReadAllText(filename);
            List<Atom> allAtoms = JsonSerializer.Deserialize<List<Atom>>(jsonFromFile);

            foreach(Atom atom in allAtoms)
            {
                Console.WriteLine(atom);
                Console.WriteLine();    
            }

        }
    }

}
