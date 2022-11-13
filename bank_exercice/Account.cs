using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal abstract class Account
    {
        private double _balance;
        public string Number
        {
            get; set;
        }
        public double Balance
        {
            get => _balance;
        }
        //{
        //    get; protected set;
        //}
        public double CreditLine
        {
            get; set;
        }
        public Person Owner
        {
            get;
        }
        //{
        //    get; private set;
        //}

        protected Account(string number, double balance, double creditLine, Person owner)
        {
            this.Number = number;
            this._balance = balance;
            this.CreditLine = creditLine;
            this.Owner = owner;
        }

        public virtual void Withdraw(double amount)
        {
            this._balance -= amount;
            Console.WriteLine("La somme de " + amount + "€ a été retirée du compte " + this.Number);
        }
        public virtual void Deposit(double amount)
        {
            this._balance += amount;
            Console.WriteLine("La somme de " + amount + "€ a été déposée sur le compte " + this.Number);
        }
        protected abstract double CalculInterest();

        public void ApplyInterest()
        {
            {
                this._balance += CalculInterest();
            }
        }
    }
}
