using System;
namespace Encapsulation.Models
{
    public class Fruit
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public string CountryOfOrigin { get; private set; }

        public Fruit (string name, string color, string countryOfOrigin)
        {
            Name = name;
            Color = color;
            CountryOfOrigin = countryOfOrigin;
        }
        
        public string GetDetails()
        {
            return $"It is {Name} it's colour is {Color}, it came from {CountryOfOrigin}.";
        }
        
    }

    public class Lemon : Fruit
    {
        public Lemon(string name, string color, string countryOfOrigin) : base( name,  color,  countryOfOrigin)
        {

        }
    }

    public class Orange : Fruit
    {
        public Orange(string name, string color, string countryOfOrigin) : base( name,  color,  countryOfOrigin)
        {
            
        }
    }
}

