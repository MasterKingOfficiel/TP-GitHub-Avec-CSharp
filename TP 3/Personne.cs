using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
    public class Personne
    {
        private int idP;
        private string nomP;
        private string prenomP;
        private static int dernierIdP = 0;
        public Personne()
        {
            dernierIdP++;
            idP = dernierIdP;
        }
        public Personne(string Nom, string Prenom)
        {
            dernierIdP++;
            idP = dernierIdP;
            nomP = Nom.ToUpper();
            prenomP = Prenom[0].ToString().ToUpper() + Prenom.Substring(1).ToLower();
        }
        public int GetId()
        {
            return idP;
        }
        public void SetNom(string Nom)
        {
            nomP = Nom.ToUpper();
        }
        public string GetNom()
        {
            return nomP;
        }
        public void SetPrenom(string Prenom)
        {
            prenomP = Prenom[0].ToString().ToUpper() + Prenom.Substring(1).ToLower();
        }
        public string GetPrenom()
        {
            return prenomP;
        }
        public void AfficherPersonne()
        {
            Console.WriteLine(nomP + " " + prenomP + ".");
        }
    }
}
