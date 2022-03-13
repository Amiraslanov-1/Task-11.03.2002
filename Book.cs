using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFebruary_11
{
     class Book:Product
    {





        public Book(string genre, int id, string name, double price,  int count ) : base(id, name, price, count)
        {
            this.Janr = genre;
        }
        public string Janr;


        public string GetInfo()
        {
            return $"ID: {this.ProductID} - Count: {this.Count} - Name: {this.ProductName}  Genre: {this.Janr} - Price: {this.ProductPrice} ";
        }


    }
}
