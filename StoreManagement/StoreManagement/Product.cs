using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement
{
    internal class Product
    {
        public string Name;
        public string Producer;
        public int Quantity;

        public Product(string name, string producer, int quantity)
        {
            Name = name;
            Producer = producer;
            Quantity = quantity;
        }

        public string getData()
        {
            return $"{Name};{Producer};{Quantity}";
        }


    }
}
