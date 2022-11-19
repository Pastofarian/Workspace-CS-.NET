using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal class CurrentAccount : Account
    {
        //public string Number;
        //public double Balance
        //{
        //    get; protected set;
        //} //protected et pas private ?
        //public double CreditLine;
        //public Person Owner;

        public CurrentAccount(string number, double balance, double creditLine, Person owner) : base(number, balance, creditLine, owner)
        {
            //this.number = number;
            //this.balance = balance;
            //this.CreditLine = creditLine;
            //this.owner = owner;
        }

        //public override void Withdraw(double amount)
        //{
        //    this.Balance -= amount;
        //    Console.WriteLine("La somme de " + amount + "€ a été retirée du compte " + this.number);
        //}

        //public override void Deposit(double amount)
        //{
        //    this.balance += amount;
        //    Console.WriteLine("La somme de " + amount + "€ a été déposée sur le compte " + this.number);
        //}

        protected override double CalculInterest()
        {
            double newBalance = 0.00;
            double interest = 0.00;
            if (Balance >= 0)
            {
                interest = Balance * 0.03;
                newBalance = this.Balance + interest;

                Console.WriteLine("3% d'intérets (" + interest + "€) ont été appliqués au compte " + this.Number + " \nSolde = " + newBalance);
                return interest;
            }
            else //si le compte est en négatif
            {
                interest = Balance * 0.0975;
                newBalance = this.Balance + interest;

                Console.WriteLine("9,75% d'intérets négatif (" + interest + "€) ont été appliqués au compte " + this.Number + " \nSolde = " + newBalance);
                return interest;
            }


        }

    }
}
