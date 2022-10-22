using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours6.Exo
{
    internal class CurrentAccount
    {
        //constructeur
        public CurrentAccount(string number, double balance, double creditLine, Person person)
        {
            Number = number;
            _balance = balance;
            CreditLine = creditLine;
            Owner = person;
        }
        //variable privé
        private double _balance;
        //propriétés
        public string Number
        {
            get; set;
        }
        public double Balance
        {
            get {
                return _balance;
            }
        }
        public double CreditLine
        {
            get; set;   
        }
        public Person Owner
        {
            get; set; 
        }
        public void Withdrawal(double amount)
        {
            _balance -= amount;
        }
        public void Deposit(double balance, double amount)
        {
            _balance += amount;
        }

    }
}
