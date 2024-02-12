
public class Serie5
{
    internal class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Sexe { get; set; }
        public bool Est_ingenieur { get; set; }

        public Personne(string nom, string prenom, bool ingenieur = false)
        {
            Nom = nom;
            Prenom = prenom;
            Est_ingenieur = ingenieur;
        }

        public Personne(string nom, string prenom, int age, string sexe)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Sexe = sexe;
        }

        public Personne(string nom, string prenom, int age, string sexe, bool ingenieur)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Sexe = sexe;
            Est_ingenieur = ingenieur;
        }
    }

    public static void Ex1()
    {
        List<List<Personne>> personnes = new List<List<Personne>>
        {
            new List<Personne>()
            {
                new Personne("Drucker", "Michel"),
                new Personne("Bedia", "Ramzy"),
                new Personne("Judor", "Eric")
            },
            new List<Personne>()
            {
                new Personne("Diaz", "Cameron"),
                new Personne("Depardieu", "Gerard"),
                new Personne("Stallone", "Sylvester"),
                new Personne("Macron", "Emmanuel")
            },
            new List<Personne>()
            {
                new Personne("Benzema", "Karim"),
                new Personne("Antoine", "Eric"),
                new Personne("Ruiz", "Olivia"),
                new Personne("Clavier", "Christian"),
                new Personne("Einstein", "Albert")
            }
        };
        
        Console.WriteLine("Ex1");
        Console.WriteLine("Names longer than 5 chars:");
        var namesLongerThan5Chars = personnes.SelectMany(pL => pL).Where(p => p.Nom.Length > 5);
        Utils.logEnum(namesLongerThan5Chars, "Nom");
        Console.WriteLine("LastNames that contains e FirstNames that contains a sorted by Lastnames:");
        var lastNamesContainsEFirstNamesContainsASortedByLastnames = personnes.SelectMany(pL => pL).Where(p => p.Nom.Contains("e") && p.Prenom.Contains("a")).OrderBy(p => p.Nom).Select(p => new {identity = p.Prenom + " " + p.Nom});
        Utils.logEnum(lastNamesContainsEFirstNamesContainsASortedByLastnames, "identity");
    }
}