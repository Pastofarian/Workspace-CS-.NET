using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal class Savings : Account
    {
        public DateTime DateLastWithdraw;

        public Savings(string number, double balance, double creditLine, Person owner, DateTime dateLastWithdraw) : base(number, balance, creditLine, owner)
        {
            this.DateLastWithdraw = dateLastWithdraw;
        }

        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //    Console.WriteLine("La somme de " + amount + "€ a été retirée du compte d'épargne " + this.number);
        //}
        //public override void Deposit(double amount)
        //{
        //    Balance += amount;
        //    Console.WriteLine("La somme de " + amount + "€ a été déposée sur le compte d'épargne " + this.number);
        //}

        protected override double CalculInterest()
        {
            double newBalance = 0.00;
            double interest = 0.00;

            interest = Balance * 0.045;
            newBalance = this.Balance + interest;
            Console.WriteLine("4,5% d'intérets (" + interest + "€) ont été appliqués au compte " + this.Number + " \nSolde = " + newBalance);
            return newBalance * 0.045;
        }
    }
}
