using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    class Bank
    {
        public Dictionary<string, CurrentAccount> accounts
        {
            get; private set;
        }
        string name;

        public Bank(Dictionary<string, CurrentAccount> account, string name)
        {
            this.accounts = account;
            this.name = name;
        }

        public void AddAccount(CurrentAccount account)
        {
            this.accounts.Add(account.number, account);
            Console.WriteLine("Le compte " + account.number + " a été ajouté au compte(s) de " + account.owner.firstName + " " + account.owner.lastName);
        }

        public void DeleteAccount(string number)
        {
            this.accounts.Remove(number);
        }

        public void DisplayCurrentAccount(CurrentAccount currentAccount)
        {
            Console.WriteLine("Le solde du compte " + currentAccount.number + " de " + currentAccount.owner.firstName + " " + currentAccount.owner.lastName + " est de " + currentAccount.balance + "€");
        }

        public void DisplaySumAllAccout(Person person)
        {
            double result = 0;
            foreach (var account in accounts)
            {
                result += account.Value.balance;
            }
            Console.WriteLine("Le solde des comptes de " + person.firstName + " " + person.lastName + " est de " + result + "€");
        }
        public void DisplaySavingAccount(Savings account)
        {
            Console.WriteLine("Le solde du compte d'épargne " + account.number + " de " + account.owner.firstName + " " + account.owner.lastName + " est de " + account.balance + "€");
        }
    }
}
