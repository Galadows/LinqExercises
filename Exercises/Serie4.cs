
public static class Serie4
{
    internal class Personne{ 
        public string Nom{ get ; set ; } 
        public string Prenom{get ; set ;} 
        public int Age{ get ; set ; } 
        public string Sexe{get ; set ;} 
        public bool Est_ingenieur{get ; set ; } 
        public Personne(string nom, string prenom, bool ingenieur) { 
            Nom = nom; 
            Prenom = prenom; 
            Est_ingenieur = ingenieur; 
        } 
        public Personne(string nom, string prenom, int age, string sexe) { 
            Nom = nom; 
            Prenom = prenom; 
            Age = age; 
            Sexe = sexe; 
        } 
        public Personne(string nom, string prenom, int age, string sexe, bool ingenieur){ 
            Nom = nom; 
            Prenom = prenom; 
            Age = age; 
            Sexe = sexe; 
            Est_ingenieur = ingenieur; 
        }    
    } 
    
    public static void Ex1()
    {
        List<Personne> personnes = new List<Personne> { 
            new Personne("Beauvoir", "Simon", 16, "M"), 
            new Personne("Beauvoir", "Simone", 25, "F"), 
            new Personne("De Caunes", "Richard", 41, "M"), 
            new Personne("Sullivan", "Sullivan", 31, "M"), 
            new Personne("Rémy", "Camille", 22, "F"), 
            new Personne("Manchon", "Camille", 19, "M"), 
            new Personne("Thiebaud", "Marie", 61, "F"), 
            new Personne("Crouchon", "Mélanie", 55, "F"), 
            new Personne("Baline", "Mélodie", 74, "F"), 
            new Personne("Karine", "Pascal", 31, "M"), 
            new Personne("Katherine", "Pascale", 36, "F"), 
            new Personne("Zoula", "Charles", 20, "M"), 
            new Personne("Romain", "Collin", 34, "M"), 
            new Personne("Fouchard", "Aïcha", 48, "F"), 
            new Personne("Blandine", "Maëva", 18, "F") 
        }; 
        
        Console.WriteLine("Ex1");
        Console.WriteLine("Fullnames and Age:");
        var fullNameAndAge = personnes.Select(p => new {FullName = p.Prenom + " " + p.Nom, Age = p.Age});
        Utils.logEnum(fullNameAndAge, new string[]{"FullName", "Age"});
        Console.WriteLine("Initials, no minors,only bellow 50 years old:");
        var initialsNoMinorsOnlyBellow50 = personnes.Where(p => p.Age > 18 && p.Age < 50).Select(p => new {Firstname = p.Prenom,Lastname = p.Nom,Initials = p.Prenom[0] + "." + p.Nom[0] + ".",Fullname_lenght = p.Prenom.Length + p.Nom.Length,  Age = p.Age});
        Utils.logEnum(initialsNoMinorsOnlyBellow50, new string[]{"Firstname", "Lastname", "Initials", "Fullname_lenght", "Age"});
    }
}