using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal class Bank
    {
        public Dictionary<string, Account> Accounts
        {
            get; private set;
        }
        string Name;

        public Bank(Dictionary<string, Account> account, string name)
        {
            this.Accounts = account;
            this.Name = name;
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account.Number, account);
            Console.WriteLine("Le compte " + account.Number + " a été ajouté au compte(s) de " + account.Owner.FirstName + " " + account.Owner.LastName);
        }

        public void DeleteAccount(string number)
        {
            this.Accounts.Remove(number);
        }

        public void DisplayCurrentAccount(CurrentAccount currentAccount)
        {
            Console.WriteLine("Le solde du compte " + currentAccount.Number + " de " + currentAccount.Owner.FirstName + " " + currentAccount.Owner.LastName + " est de " + currentAccount.Balance + "€");
        }

        //public void DisplaySumAllAccout(Person person) //le account n'est pas lié à la personne 
        //{
        //    double result = 0;
        //    foreach (var account in Accounts)
        //    {
        //        result += account.Value.Balance;
        //    }
        //    Console.WriteLine("Le solde des comptes de " + person.FirstName + " " + person.LastName + " est de " + result + "€");
        //}

        public void DisplaySumAllAccout(Person person)
        {
            double sumAllAccount = 0;
            foreach (var account in Accounts)
            {
                //Console.WriteLine(account.Value.Owner.LastName);
                if (account.Value.Owner.LastName == "Doe")
                {
                    sumAllAccount += account.Value.Balance;
                }
                //Console.WriteLine("balance " + account.Value.Balance + account.Value.Number);
            }
            Console.WriteLine("somme totale des comptes de " + person.FirstName + " " + person.LastName + " est de " + sumAllAccount + "€");
        }

        public void DisplaySavingAccount(Savings account)
        {
            Console.WriteLine("Le solde du compte d'épargne " + account.Number + " de " + account.Owner.FirstName + " " + account.Owner.LastName + " est de " + account.Balance + "€");
        }
    }
}
