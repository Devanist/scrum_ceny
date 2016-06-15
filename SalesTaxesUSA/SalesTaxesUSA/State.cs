using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesUSA
{
    class State
    {
        public String name { get; set; }
        double baseTax { get; set; }

        public State(String name, double baseTax)
        {
            this.name = name;
            this.baseTax = baseTax;
        }
    }


}
