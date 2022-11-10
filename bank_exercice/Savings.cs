using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    class Savings : CurrentAccount
    {
        public DateTime dateLastWithdraw;

        public Savings(string number, double balance, Person owner, DateTime dateLastWithdraw) : base(number, balance, 0.00f, owner) //creditLine = 0.00
        {
            this.dateLastWithdraw = dateLastWithdraw;
        }

        public override void Withdraw(double amount)
        {
            this.balance -= amount;
            Console.WriteLine("La somme de " + amount + "€ a été retirée du compte d'épargne " + this.number);
        }
        public override void Deposit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("La somme de " + amount + "€ a été déposée sur le compte d'épargne " + this.number);
        }
    }
}
