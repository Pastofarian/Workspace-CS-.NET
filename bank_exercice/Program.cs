using System;
using System.Security.Principal;
using System.Text;

namespace bank_exercice
{
    class Program
    {
        class Person
        {
            public string firstName;
            public string lastName;
            public DateTime birthDate;

            public Person(string firstName, string lastName, DateTime birthDate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthDate = birthDate;
            }
        }

        class CurrentAccount
        {
            public string number;
            public double balance { get; private set; }
            public double creditLine;
            public Person owner;

            public CurrentAccount(string number, double balance, double creditLine, Person owner)
            {
                this.number = number;
                this.balance = balance;
                this.creditLine = creditLine;
                this.owner = owner;
            }

            public void Withdraw(double amount)
            {
                this.balance -= amount;
                Console.WriteLine("La somme de " + amount +"€ a été retirée du compte " + this.number);
            }

            public void Deposit(double amount)
            {
                this.balance += amount;
                Console.WriteLine("La somme de " + amount + "€ a été déposée sur le compte " + this.number);
            }
        }

        class Bank
        {
            public Dictionary<string, CurrentAccount> accounts { get; private set; }
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
                Console.WriteLine("Le solde du compte " + currentAccount.number + " de " + currentAccount.owner.firstName + " " + currentAccount.owner.lastName +  " est de " + currentAccount.balance + "€");
            }

            public void DisplaySumAllAccout(Person person)
            {
                double result = 0;
                foreach (var account in accounts)
                {
                    result += account.Value.balance;
                }
                 
                Console.WriteLine("Le solde des comptes de " + person.firstName + " "+ person.lastName + " est de " + result + "€");
            }

        }

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8; //pour le signe €

            Person person1 = new Person("John", "Doe", new DateTime(1991, 05, 25));
            CurrentAccount currentAccount1 = new CurrentAccount("BE45-9897881-36", 100,00f, person1);
            CurrentAccount currentAccount2 = new CurrentAccount("BE45-9898954-63", 500,00f, person1);

            var accountPerson1 = new Dictionary<string, CurrentAccount> { { "BE45-9897881-36", currentAccount1 } };
            Bank bank1 = new Bank(accountPerson1, "Argenta");

            bank1.DisplayCurrentAccount(currentAccount1);
            Console.WriteLine();
            bank1.DisplayCurrentAccount(currentAccount2);
            Console.WriteLine();

            bank1.AddAccount(currentAccount2);
            Console.WriteLine();

            currentAccount2.Withdraw(150);
            Console.WriteLine();

            currentAccount1.Deposit(200);
            Console.WriteLine();

            bank1.DisplaySumAllAccout(person1);


        }
    }
}
