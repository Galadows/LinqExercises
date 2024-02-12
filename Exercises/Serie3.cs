
public static class Serie3
{
    internal class Personne{ 
        public string Nom{ get ; set ; } 
        public string Prenom{get ; set ;} 
        public bool Est_ingenieur{get ; set ; } 
        public Personne(string nom, string prenom, bool ingenieur) 
        { 
            Nom = nom; 
            Prenom = prenom; 
            Est_ingenieur = ingenieur; 
        } 
    } 
    internal class Ingenieur { 
        public string Nom{get ; set ; } 
        public string Prenom{get ; set ;} 
        public string Specialite{get ; set ; } 
        public Ingenieur(string nom, string prenom){ 
            Nom = nom; 
            Prenom = prenom; 
        } 
        public Ingenieur(string nom, string prenom, string specialite){ 
            Nom = nom; 
            Prenom = prenom; 
            Specialite = specialite; 
        } 
    } 
 
    internal class Technicien{ 
        public string Nom{get ; set ;}
        public string Prenom{get ; set ;} 
        public Technicien(string nom, string prenom){ 
            Nom = nom; 
            Prenom = prenom; 
        } 
    }

    public static void Ex1()
    {
        List<Personne> personnes = new List<Personne> { 
            new Personne("Hallyday", "Johnny", false), 
            new Personne("Vartan", "Sylvie", false), 
            new Personne("Drucker", "Michel", false), 
            new Personne("Antoine", "Antoine", true), 
            new Personne("Philippe", "Edouard", false), 
            new Personne("Demorand", "Patricia", true), 
            new Personne("Ulysse", "Margareth", true), 
            new Personne("Zenith", "Méryl", true), 
            new Personne("Bobo", "Jojo", false) 
        };
        
        List<Ingenieur> ingenieurs = new List<Ingenieur> { 
            new Ingenieur("Antoine", "Antoine", "Informatique"), 
            new Ingenieur("Demorand", "Patricia", "Mécanique"), 
            new Ingenieur("Ulysse", "Margareth", "Informatique"), 
            new Ingenieur("Zenith", "Méryl", "Mécanique") 
        };
        
        List<Technicien> techniciens = new List<Technicien> { 
            new Technicien("Hallyday", "Johnny"), 
            new Technicien("Vartan", "Sylvie"), 
            new Technicien("Drucker", "Michel"), 
            new Technicien("Philippe", "Edouard"), 
            new Technicien("Bobo", "Jojo") 
        };
        
        Console.WriteLine("Ex1");
        Console.WriteLine("Ingenieurs:");
        Utils.logEnum<Ingenieur>(ingenieurs, new string[]{ "Nom", "Prenom", "Specialite" });
        Console.WriteLine("Techniciens:");
        Utils.logEnum<Technicien>(techniciens, new string[]{ "Nom", "Prenom" });
    }
    
}