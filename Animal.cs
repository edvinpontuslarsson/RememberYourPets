using System;

namespace RememberYourPets
{
    public abstract class Animal
    {
        private string _species;

        public string Species
        {
            get => _species;
            private set { _species = value; }
        }
        
        protected Animal(string species)
        {
            Species = species;
        }
    }
}