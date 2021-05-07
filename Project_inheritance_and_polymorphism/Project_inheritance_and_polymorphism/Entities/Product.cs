using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_inheritance_and_polymorphism.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; protected set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $" + Price.ToString("F2");
        }

    }
}
