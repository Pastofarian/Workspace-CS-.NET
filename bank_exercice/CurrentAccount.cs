using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    class CurrentAccount
    {
        public string number;
        public double balance
        {
            get; protected set;
        } //protected et pas private ?
        public double creditLine;
        public Person owner;

        public CurrentAccount(string number, double balance, double creditLine, Person owner)
        {
            this.number = number;
            this.balance = balance;
            this.creditLine = creditLine;
            this.owner = owner;
        }

        public virtual void Withdraw(double amount)
        {
            this.balance -= amount;
            Console.WriteLine("La somme de " + amount + "€ a été retirée du compte " + this.number);
        }

        public virtual void Deposit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("La somme de " + amount + "€ a été déposée sur le compte " + this.number);
        }
    }
}
