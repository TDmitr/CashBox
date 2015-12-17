using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox
{
    public struct CheckItems
    {
        public string Product { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public double Sum { get; set; }
        public int Id { get; set; }

        //public CheckItems(Products product, int amount)
        //{
        //    Product = product.Name;
        //    Price = product.Price;
        //    Id = product.Id;
        //    Amount = amount;
        //    Sum = (double) (product.Price*amount);
        //}
    }
}
