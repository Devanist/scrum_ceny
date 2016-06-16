using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesUSA
{
    class Product
    {
        int id { get; set; }
        public String name { get; set; }
        public float basePrice { get; set; }
        float endPrice { get; set; }
        //ProductCategory productCategory { get; set; }

        public Product(int id, String name, float basePrice, float endPrice)
        {
            this.id = id;
            this.name = name;
            this.basePrice = basePrice;
            this.endPrice = endPrice;
        }

    }
}
