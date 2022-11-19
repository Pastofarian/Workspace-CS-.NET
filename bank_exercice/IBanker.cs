using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal interface IBanker
    {
        void ApplyInterest();

        Person Owner
        {
            get;
        }
        string Number
        {
            get;
        }
    }
}
