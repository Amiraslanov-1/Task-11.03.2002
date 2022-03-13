using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFebruary_11
{
  class Product
    {


        public int ProductID;
        public string ProductName;
        public double ProductPrice;
        public int Count;
        public Product(int id, string name, double price, int count)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.ProductPrice = price;
            this.Count = count;

        }
    };

}
