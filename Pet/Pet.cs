using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    internal class Pet
    {
        public string Name { get; }
        public string Owner { get; private set; }
        public int Age { get; }
        public string Description { get; }
        public bool IsHouseTrained {  get; private set; }


        public Pet (string name, int age, string description)
        {
            Name = name;
            Owner = "no one";
            Age = age;
            Description = description;
            IsHouseTrained = false;
        }

        public void Train()
        {
            IsHouseTrained = true;
        }

        public void SetOwner(string newOwner)
        {
            Owner = newOwner;
        }



        public override string ToString()
        {
            string trained = IsHouseTrained ? "Yes" : "No";
            return $"Pet Name:{Name}\nOwner: {Owner}\nAge: {Age}\nDescription: {Description}\nTrained: {trained}";
        }

    }
}
