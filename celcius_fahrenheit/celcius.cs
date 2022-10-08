using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        public struct Celcius
        {
            public double Temperature;

            public double convFahr()
            {
                return (Temperature * 9) / 5 + 32;
            }
        }


