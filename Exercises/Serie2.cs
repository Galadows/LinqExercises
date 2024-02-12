using System;
using System.Linq;

public static class Serie2
{
    internal class Dog 
    { 
        public string Race{get ; set ;} 
        public string Name{get ; set ;}         
        public int Age{get ;set ; } 
        public int Weight{get ;set ;} 
        public Dog(string race, string name, int age, int weight){ 
            Race = race; 
            Name = name; 
            Age = age; 
            Weight = weight; 
        } 
    }

    public static void Ex1()
    {
        List<Dog> dogs = new List<Dog> { 
            new Dog("Berger Australien", "Banzaï", 1, 28), 
            new Dog("Berger Australien", "Letto", 3, 30), 
            new Dog("Berger Australien", "Princesse", 8, 32), 
            new Dog("Berger Allemand", "Floyd", 10, 32), 
            new Dog("Caniche", "Igor", 13, 9), 
            new Dog("Labrador", "Swing", 15, 25), 
            new Dog("Teckel", "Wonki", 2, 5), 
            new Dog("Terre Neuve", "Albator", 1, 50), 
            new Dog("Carlin", "Pataud", 13, 10), 
            new Dog("Boxer", "Frank", 6, 25), 
            new Dog("Lévrier Afghan", "Précieuse", 9, 26), 
            new Dog("Yorkshire", "Kakou", 3, 6) 
        };
        
        Console.WriteLine("Ex1");
        Console.WriteLine("Belgian shepherd:");
        var belgianShepherd = dogs.Where(d => d.Race == "Berger Australien");
        Utils.logEnum<Dog>(belgianShepherd, "Name");
        Console.WriteLine("Belgian shepherd sorted by name:");
        var sortedbyNameBelgianShepherd = belgianShepherd.OrderBy(d => d.Name);
        Utils.logEnum<Dog>(sortedbyNameBelgianShepherd, "Name");
        var olderThan4MoreThan5LettersName = belgianShepherd.Where(d => d.Name.Length > 5 && d.Age > 4);
        Console.WriteLine("Older than 4 and more than 5 letters name:");
        var sortedByWeight = olderThan4MoreThan5LettersName.OrderBy(d => d.Weight);
        Utils.logEnum<Dog>(sortedByWeight, "Name");
        var sortedByAgeThenWeight = belgianShepherd.OrderBy(d => d.Age).ThenBy(d => d.Weight);
        Console.WriteLine("Sorted by age then weight:");
        var oneWordRaceLessThan15KgNameContainsISortByName = dogs.Where(d => d.Race.Split(' ').Length == 1 && d.Weight < 15 && d.Name.Contains("i")).OrderBy(d => d.Name);
        Utils.logEnum<Dog>(oneWordRaceLessThan15KgNameContainsISortByName, "Name");
        
        
    }
    
}