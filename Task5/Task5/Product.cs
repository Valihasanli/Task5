using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Product
    {
        public Product(double price,byte no,string name)
        {
            Name = name;
            Price = price;
            No = no;
        }
        private double _price;
        private byte _count;
        public double Price { get { return _price; } 
                              set { 
                                   if(_price>0) _price = value; } }
        public byte Count { get { return _count; } 
                            set { if(_count>0) _count = value; } }
        public byte No;
        public string Name;

    }
}
