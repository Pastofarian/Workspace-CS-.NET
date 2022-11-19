using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal interface ICustomer
    {
        double Balance
        {
            get;
        }
        void Withdraw(double amount);
        void Deposit(double amount);
    }
}
