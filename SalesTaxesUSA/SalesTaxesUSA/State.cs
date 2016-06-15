using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesUSA
{
    class State
    {
        String name { get; set; }
        float baseTax { get; set; }

        public State(String name, float baseTax)
        {
            this.name = name;
            this.baseTax = baseTax;
        }
    }


}
