using System;
using System.Numerics;
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

        public abstract class Account //: Savings Pourquoi ?? La class Savings fait le job ??
        {
            protected void CalculInterest()
            {
                /* Ajouter une méthode abstraite « protected » à la classe « Account » ayant le
                 prototype « double CalculInterets() » en sachant que pour un livret d’épargne le
                 taux est toujours de 4.5% tandis que pour le compte courant si le solde est positif
                 le taux sera de 3% sinon de 9.75%.*/
            }

            public void ApplyInterest()
            {
                /*Ajouter une méthode « public » à la classe « Account » appelée « ApplyInterest » 
                qui additionnera le solde avec le retour de la méthode « CalculInterest ».*/
            }
        }

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8; //pour le signe €

            var person1 = new Person("John", "Doe", new DateTime(1991, 05, 25));
            var currentAccount1 = new CurrentAccount("BE45-9897881-36", 100, 00f, person1);
            var currentAccount2 = new CurrentAccount("BE45-9898954-63", 500, 00f, person1);

            var savingAccount1 = new Savings("BE45-96852231-83", 10000.00f, person1, new DateTime(2022, 10, 25));

            var accountPerson1 = new Dictionary<string, CurrentAccount> { { "BE45-9897881-36", currentAccount1 } };
            var bank1 = new Bank(accountPerson1, "Argenta");

            bank1.DisplayCurrentAccount(currentAccount1); //Affiche le solde du compte currentAccount1
            Console.WriteLine();

            bank1.DisplayCurrentAccount(currentAccount2); //Affiche le solde du compte currentAccount2
            Console.WriteLine();

            bank1.AddAccount(currentAccount2); //Ajoute un nouveau compte mais comment lier à un owner sans le new ? C'est tricher.
            Console.WriteLine();

            currentAccount2.Withdraw(150); //Retire 150€ de currentAccount2
            Console.WriteLine();

            currentAccount1.Deposit(200); //Depose 200€ sur currentAccount1
            Console.WriteLine();

            savingAccount1.Withdraw(1000); //Retire 1000€ de savingAccount1
            Console.WriteLine();

            bank1.DisplaySavingAccount(savingAccount1); //Affiche le solde du compte savingAccount1
            Console.WriteLine();

            bank1.DisplaySumAllAccout(person1); //Affiche tous les comptes de person1 mais pas les savings
            Console.WriteLine();
        }
    }
}
