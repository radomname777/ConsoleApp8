using System;
using System.Text.Json;

namespace MyApp
{
    class World
    {
        public string[][] Dictionary { get; set; }
        public string? this[string country]
        {
            get
            {
                string[][] text = new string[][] { File.ReadAllLines("dictionary.txt") };
                World user = new World();
                foreach (var item in text)
                {
                    string[][] ss = JsonSerializer.Deserialize<string[][]>(item[0]);
                    foreach (var item1 in ss)
                    {
                        if (item1[0].ToUpper() == country.ToUpper())return item1[1];
                        else if(item1[1].ToUpper() == country.ToUpper()) return item1[0];
                    }
                }
                return "Tapilmadi";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            World dictionary = new World();
            dictionary.Dictionary = new string[][]{
                new string[2] { "Hello", "Salam"},new string[2] { "How", "Nece"},
                new string[2] { "You", "Sen"},    new string[2] { "World", "Dunya"},
                new string[2] { "We", "Biz"},     new string[2] { "Home", "Ev"},
                new string[2] { "Dog", "it"},     new string[2] { "Cat", "pisik"},
                new string[2] { "Parrot", "tutuqusu"}, new string[2] { "Ocean", "Okean"},
                new string[2] { "War", "Muharibe"},    new string[2] { "flame", "Alow"},
                new string[2] { "Car", "masin"},       new string[2] { "Caspian", "Xezer"},
                new string[2] { "flower", "Gul"},      new string[2] { "Mountain", "Dag"},
                new string[2] { "Sun", "Gunes"},       new string[2] { "Computer", "Komputer"},
                new string[2] { "Qaz", "Goose"},       new string[2] { "COw", "Inek"}
            };
            var json = JsonSerializer.Serialize(dictionary.Dictionary);
            File.WriteAllText("dictionary.txt", json + '\n');
            Console.WriteLine(dictionary["you"]);
            Console.WriteLine(dictionary["sen"]);
        }
    }
}