namespace TP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne P1 = new Personne("Palpatine", "Sidious");
            Compte C1 = new Compte(2003, 0066, P1);
            Personne P2 = new Personne("Potter", "Harry");
            Compte C2 = new Compte(1999, 3107, P2);
            Personne P3 = new Personne("Wonder", "Woman");
            Compte C3 = new Compte(1941, 2110, P3);
            Personne P4 = new Personne("Parker", "Peter");
            Compte C4 = new Compte(1961, 1234, P4);
            List<Compte> ListeDeCompte = new List<Compte>() { C1, C2, C3, C4 };
            string Initialisation;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saisissez votre code pour accéder aux fonctionnalités :");
                Console.WriteLine("Taper 0000 pour fermer l'application");
                Console.ForegroundColor = ConsoleColor.White;
                Initialisation = Console.ReadLine();
                int Code;
                if (Initialisation == "0000")
                {
                    Initialisation = "Fermer l'application";
                }
                else if (int.TryParse(Initialisation, out Code) != true)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur lors de la saisie du code, veuillez saisir un nombre !");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                else if (int.TryParse(Initialisation, out Code) == true)
                {
                    Compte CompteConnecte = null;
                    int i = 0;
                    foreach (Compte Compte in ListeDeCompte)
                    {
                        if (Code == Compte.GetCode())
                        {
                            CompteConnecte = Compte;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Bienvenue ");
                            CompteConnecte.GetPersonne();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                        }
                        else
                        {
                            i++;
                        }
                    }
                    if (CompteConnecte != null)
                    {
                        Initialisation = CompteConnecte.Menu();
                    }
                    if (i == 4)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Aucun compte ne correspond à ce code !");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }

                }
            }
            while (Initialisation != "Fermer l'application");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fin du programme.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}