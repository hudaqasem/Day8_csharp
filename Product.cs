using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Product: IComparable
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        #endregion

        #region constructor
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        } 
        #endregion

        #region Method
        public int CompareTo(object? obj)
        {
            Product product = (Product)obj;

            if (this.Price > product.Price)
                return 1;
            else if (this.Price < product.Price)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"ID = {Id} , Name = {Name} , Price = {Price}";
        }
        #endregion


    }
}
