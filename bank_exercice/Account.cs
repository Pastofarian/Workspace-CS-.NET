using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal abstract class Account : ICustomer, IBanker
    {
        private double _balance;
        private Person _owner;

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
            get => _owner;
        }
        //{
        //    get; private set;
        //}

        protected Account(string number, double balance, double creditLine, Person owner)
        {
            this.Number = number;
            this._balance = balance;
            this.CreditLine = creditLine;
            this._owner = owner;
        }

        protected Account(string number, Person owner)
        {
            Number = number;
            Owner = owner;
        }

        protected Account(double balance, string number, Person owner)
        {
            _balance = balance;
            Number = number;
            Owner = owner;
        }

        public virtual void Withdraw(double amount)
        {
            double total = this._balance - amount;
            if (total < this.CreditLine)
            {
                //Console.WriteLine("total" + total);
                //Console.WriteLine("CreditLine" + this.CreditLine);
                Console.WriteLine($"impossible de retirer {amount}€\nVotre solde est de {_balance}€\nVotre solde négatif maximum est de {CreditLine}€.");
            }
            else
            {
                Console.WriteLine("La somme de " + amount + "€ a été retirée du compte " + this.Number);
                this._balance -= amount;
            }
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
