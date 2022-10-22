
using Cours6.Exo;
using Cours6.Models;

namespace NewConsoleApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Pouet pouet = new Pouet();
            Person person1 = new Person("Doe", "Joe", new DateTime(1991, 05, 25));
            Bank bank1 = new Bank("Argenta");
            CurrentAccount currentAccount1 = new CurrentAccount("123456", 1000, 100, person1);
            bank1.AddAccount(currentAccount1);
        }
    }
}
