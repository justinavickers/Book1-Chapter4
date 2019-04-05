using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){
                "Mercury",
                 "Mars"
                 };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> otherPlanets = new List<string>() {
                "Uranus",
                "Neptune"
            };

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.AddRange(otherPlanets);
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            foreach ( string rocky in rockyPlanets) {
                Console.WriteLine(rocky);
            }

            foreach( string planet in planetList ) {
            Console.WriteLine(planet);
            }
        }
    }
}
