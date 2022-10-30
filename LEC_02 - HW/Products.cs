using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_02___HW
{
    internal class Products
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Stock { get; set; }

        public Products (string name, int number, string stock)
        {
            Name = name;
            Number = number;
            Stock = stock;
        }
    }
}
