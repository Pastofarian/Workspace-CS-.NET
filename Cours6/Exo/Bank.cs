using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cours6.Exo
{
    internal class Bank
    {
        private Dictionary<string, CurrentAccount> _accounts
        {
            get
            {
                return _accounts;
            }
            set
            {
                _accounts = value;
            }
        }
        //Constructeur
        public Bank(string? name)
        {
            Name = name;
            _accounts = new Dictionary<string, CurrentAccount>();
        }

        //Propriétés
        public Dictionary<string, CurrentAccount> Accounts
        {
            get { return _accounts; }
        }
        public string? Name
        {
            get; set;
        }

        // Fonctions
        public void AddAccount(CurrentAccount account)
        {
            _accounts.Add(account.Number, account);
        }
        public void DeleteAccount(string accountNumber)
        {
            _accounts.Remove(accountNumber);
        }
        public void GetSommeAccount(CurrentAccount currentAccount)
        {
            Console.WriteLine(currentAccount.Balance);
        }
    }
}
