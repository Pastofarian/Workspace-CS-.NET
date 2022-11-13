using System;
using System.Numerics;
using System.Security.Principal;
using System.Text;

namespace bank_exercice
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8; //pour le signe €

            var person1 = new Person("John", "Doe", new DateTime(1991, 05, 25));
            var currentAccount1 = new CurrentAccount("BE45-9897881-36", 100, 00f, person1);
            var currentAccount2 = new CurrentAccount("BE45-9898954-63", 500, 00f, person1);

            var savingAccount1 = new Savings("BE45-96852231-83", 10000.00f, person1, new DateTime(2022, 10, 25));

            var accountPerson1 = new Dictionary<string, Account> { { "BE45-9897881-36", currentAccount1 } };
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

            currentAccount2.Withdraw(1000); //Retire 1000€ de currentAccount2 (négatif)
            Console.WriteLine();

            bank1.DisplaySavingAccount(savingAccount1); //Affiche le solde du compte savingAccount1
            Console.WriteLine();

            bank1.DisplaySumAllAccout(person1); //Affiche tous les comptes de person1 mais pas les savings
            Console.WriteLine();

            currentAccount2.ApplyInterest(); //Applique les intérets négatif au compte courant currentAccount2
            Console.WriteLine();

            currentAccount1.ApplyInterest(); //Applique les intérets au compte courant currentAccount1
            Console.WriteLine();

            savingAccount1.ApplyInterest(); //Applique les intérets au compte d'épargne savingAccount1
            Console.WriteLine();
        }
    }
}
//J'ai un soucis pour lier les comptes à une personne. Voir la fonction addAccount() et DisplaySumAllAccount()
//Ce serait bien d'ajouter le compte d'épargne à DisplaySumAllAccount()
// + un système de virement