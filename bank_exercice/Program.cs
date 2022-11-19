﻿using System;
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
            var currentAccount1 = new CurrentAccount("BE45-9897881-36", 100.00f, -1000.00f, person1);
            var currentAccount2 = new CurrentAccount("BE45-9898954-63", 500.00f, -1000.00f, person1);

            var savingAccount1 = new Savings("BE45-96852231-83", 10000.00f, 00.00f, person1, new DateTime(2022, 10, 25));

            var accountPerson1 = new Dictionary<string, Account> { { "BE45-9897881-36", currentAccount1 } };
            var bank1 = new Bank(accountPerson1, "Argenta");

            bank1.AddAccount(currentAccount2); //Ajoute un nouveau compte lié à une personne
            Console.WriteLine();

            bank1.AddAccount(savingAccount1); //Ajoute un nouveau compte d'épargne lié à une personne
            Console.WriteLine();

            bank1.DisplayCurrentAccount(currentAccount1); //Affiche le solde du compte currentAccount1
            Console.WriteLine();

            bank1.DisplayCurrentAccount(currentAccount2); //Affiche le solde du compte currentAccount2
            Console.WriteLine();

            currentAccount2.Withdraw(15000); //Retire 150€ de currentAccount2
            Console.WriteLine();

            currentAccount1.Deposit(200); //Depose 200€ sur currentAccount1
            Console.WriteLine();

            currentAccount2.Withdraw(300); //Retire 1500€ de currentAccount2 
            Console.WriteLine();

            bank1.DisplaySavingAccount(savingAccount1); //Affiche le solde du compte savingAccount1
            Console.WriteLine();

            currentAccount2.ApplyInterest(); //Applique les intérets négatif au compte courant currentAccount2
            Console.WriteLine();

            currentAccount1.ApplyInterest(); //Applique les intérets au compte courant currentAccount1
            Console.WriteLine();

            savingAccount1.ApplyInterest(); //Applique les intérets au compte d'épargne savingAccount1
            Console.WriteLine();

            bank1.DisplaySumAllAccout(person1); //Affiche tous les comptes de person1 mais pas les savings
            Console.WriteLine();

        }
    }
}
//J'ai un soucis pour lier les comptes à une personne. Voir la fonction DisplaySumAllAccount()
//Ce serait bien d'ajouter le compte d'épargne à DisplaySumAllAccount()
// + un système de virement

