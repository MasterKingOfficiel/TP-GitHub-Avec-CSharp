using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
    public class Compte
    {
        private double montantC;
        private int codeC;
        private Personne objetPersonneIdC;
        public Compte()
        {
            objetPersonneIdC = new Personne();
        }
        public Compte(double Montant, int Code, Personne Personne)
        {
            objetPersonneIdC = Personne;
            montantC = Montant;
            codeC = Code;
        }
        public void SetPersonne(Personne Personne)
        {
            objetPersonneIdC = Personne;
        }
        public void GetPersonne()
        {
            objetPersonneIdC.AfficherPersonne();
        }
        public void SetMontant(double Montant)
        {
            montantC = Montant;
        }
        public double GetMontant()
        {
            return montantC;
        }
        public void SetCode(int Code)
        {
            codeC = Code;
        }
        public double GetCode()
        {
            return codeC;
        }
        public double AjoutArgent(double Montant)
        {
            montantC += Montant;
            return montantC;
        }
        public double RetirerArgent(double Montant)
        {
            montantC -= Montant;
            return montantC;
        }
        public string Menu()
        {
            string Initialisation;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 = Consulter le solde.");
                Console.WriteLine("2 = Ajouter de l'argent.");
                Console.WriteLine("3 = Retirer de l'argent.");
                Console.WriteLine("4 = Déconnexion.");
                Console.ForegroundColor = ConsoleColor.White;
                Initialisation = Console.ReadLine();
                if (Initialisation == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Le solde sur votre compte est de :");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(GetMontant() + " euros.");
                    Console.ReadLine();
                }
                else if (Initialisation == "2")
                {
                    string StringMontant;
                    double Montant;
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Saisissez le montant que vous voulez ajouter à votre compte :");
                        Console.ForegroundColor = ConsoleColor.White;
                        StringMontant = Console.ReadLine();
                        if (double.TryParse(StringMontant, out Montant) != true)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Veuillez saisir une valeur réelle !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                        }
                        if (double.TryParse(StringMontant, out Montant) == true && Montant <= 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Veuillez saisir une valeur positive !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                        }
                    }
                    while (double.TryParse(StringMontant, out Montant) != true || Montant <= 0);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Le solde sur votre compte est maintenant de :");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(AjoutArgent(Montant) + " euros.");
                    Console.ReadLine();
                }
                else if (Initialisation == "3")
                {
                    string StringMontant;
                    double Montant;
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Saisissez le montant que vous voulez retirer de votre compte :");
                        Console.ForegroundColor = ConsoleColor.White;
                        StringMontant = Console.ReadLine();
                        if (double.TryParse(StringMontant, out Montant) != true)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Veuillez saisir une valeur réelle !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                        }
                        if (double.TryParse(StringMontant, out Montant) == true && Montant <= 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Veuillez saisir une valeur positive !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                        }
                    }
                    while (double.TryParse(StringMontant, out Montant) != true || Montant <= 0);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Le solde sur votre compte est maintenant de :");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(RetirerArgent(Montant) + " euros.");
                    Console.ReadLine();
                }
                else if (Initialisation == "4")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Déconnexion du compte.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Veuillez saisir à nouveau.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
            }
            while (Initialisation != "4");
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voulez-vous quitter le programme ?");
                Console.WriteLine("1 = Oui.");
                Console.WriteLine("2 = Non.");
                Console.ForegroundColor = ConsoleColor.White;
                Initialisation = Console.ReadLine();
            }
            while (Initialisation != "1" && Initialisation != "2");
            if (Initialisation == "1")
            {
                return "Fermer l'application";
            }
            else
            {
                return "";
            }
        }
    }
}
