using System;
using System.Text.Json;

namespace MyApp
{
    class Capital
    {
        public double Territory { get; set; }
        public int Population { get; set; }
        public string Name { get; set; }
        public Capital(double territory, int population, string name)
        {
            Territory = territory;
            Population = population;
            Name = name;

        }
        public override string ToString() { return $"Capital: {Name}\nPopulation: {Population}\nTerritory: {Territory}KM"; }
    }
    class Country
    {
        public double Territory { get; set; }
        public int Population { get; set; }
        public string Name { get; set; }
        public Capital Capital { get; set; }
        public Country(double territory, int population, string name, Capital cap)
        {
            Territory = territory;
            Population = population;
            Name = name;
            Capital = cap;
        }
        public static bool operator <(Country country1, Country country2)
        {

            if (country1.Population < country2.Population)
            {
                Console.WriteLine(country2.Capital);
                return true;
            }
            return false;
        }
        public static bool operator >(Country country1, Country country2)
        {
            if (country1.Capital.Population > country2.Capital.Population)
            {
                Console.WriteLine(country1.Capital);
                return true;
            }
            return false;
        }
        public override string ToString() { return $"Country: {Name}\nPopulation: {Population}\nTerritory: {Territory}KM\n{Capital}"; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Country Coun = new Country(86600, 10173200, "Azerbaycan", new Capital(2140, 2300500, "Baki"));
            Country Coun2 = new Country(86600, 10173200, "Azerbaycan", new Capital(170, 300600, "Gence"));
            Console.WriteLine(Coun > Coun2);
            Console.WriteLine(Coun);
        }
    }
}