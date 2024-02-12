using System;
using System.Linq;

// Exercice
public static class Utils
{
    public static void logEnum<T>(IEnumerable<T> COLLECTION)
    {
        foreach (var VARIABLE in COLLECTION)
        {
            Console.Write(VARIABLE + ", ");
        }
        Console.WriteLine();
    }
    
    public static void logEnum<T>(IEnumerable<T> COLLECTION, string key)
    {
        Type type = typeof(T);
        var prop = type.GetProperty(key);
        foreach (var VARIABLE in COLLECTION)
        {
            Console.Write(prop.GetValue(VARIABLE, null) + ", ");
        }
        Console.WriteLine();
    }
}

public static class Serie1{
    


public static void Ex1()
{
    List<int> entiers = new List<int> { 4, 5, 2, 3, 1, 1, 0, 5, 8, 9, 10, 15, 16, 20, 21, 4, 5 };
    
    var greaterThan5 = entiers.Where(n => n > 5);
    var greaterOrEqualThan15 = entiers.Where(n => n >= 15 && n < 20);
    var greaterThanAndMultipleOf2LowerThan20AndNot8 = entiers.Where(n => n > 2 && n%2 == 0 && n < 20 && n != 8);
    Console.WriteLine("Ex1");
    Console.WriteLine("greater than 5:");
    Utils.logEnum<int>(greaterThan5);
    Console.WriteLine("greater or equal than 15:");
    Utils.logEnum<int>(greaterOrEqualThan15);
    Console.WriteLine("greater than 2 and multiple of 2 lower than 20 and not 8:");
    Utils.logEnum<int>(greaterThanAndMultipleOf2LowerThan20AndNot8);
    Console.WriteLine();
}

public static void Ex2()
{
    List<string> fruits = new List<string> {"Banane", "Ananas", "Cerise", "Framboise", "Groseilles", 
        "Pomme", "Poire", "Tomate", "Kiwi", "Raisin", "Mangue", "Datte"};  
    
    var moreThan5Letters = fruits.Where(f => f.Length > 5);
    var startWithPmoreThan4LettersContainsOButNotM = fruits.Where(f => f.StartsWith("P") && f.Length > 4 && f.Contains("o") && !f.Contains("m"));
    var sortedByLength = fruits.OrderBy(f => f.Length);
    Console.WriteLine("Ex2");
    Console.WriteLine("more than 5 letters:");
    Utils.logEnum<string>(moreThan5Letters);
    Console.WriteLine("start with P, more than 4 letters, contains o but not m:");
    Utils.logEnum<string>(startWithPmoreThan4LettersContainsOButNotM);
    Console.WriteLine("sorted by length:");
    Utils.logEnum<string>(sortedByLength);
    Console.WriteLine();
}
}
