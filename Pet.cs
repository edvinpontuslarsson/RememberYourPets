using System;

namespace RememberYourPets
{
    public class Pet : Animal
    {
        private string _name;
        
        public string Name
        {
            get => _name;
            private set { _name = value; }
        }

        public Pet(string species, string name): base (species)
        {
            Name = name;
        }
    }
}