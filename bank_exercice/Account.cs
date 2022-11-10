using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    public class Account //: Savings Pourquoi ?? La class Savings fait le job ??
    {
        protected void CalculInterest()
        {
            /* Ajouter une méthode abstraite « protected » à la classe « Account » ayant le
             prototype « double CalculInterets() » en sachant que pour un livret d’épargne le
             taux est toujours de 4.5% tandis que pour le compte courant si le solde est positif
             le taux sera de 3% sinon de 9.75%.*/
        }

        public void ApplyInterest()
        {
            /*Ajouter une méthode « public » à la classe « Account » appelée « ApplyInterest » 
            qui additionnera le solde avec le retour de la méthode « CalculInterest ».*/
        }
    }
}
