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
    }
}
