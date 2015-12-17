using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox
{
    class Products
    {
        public string Name { get; set; } = "";
        public int Id { get; set; } = 0;
        public double Price { get; set; } = 0;

        public Products(string name, int id, double price)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
        }
}
}
