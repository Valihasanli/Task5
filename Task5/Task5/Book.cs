using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Book : Product
    {   public string Genre;
        public Book(string genre,double price, byte no, string name,int count) : base(price, no, name)
        {
            Genre = genre;
        }
        public void ShowInfo(Book book)
        {
            Console.WriteLine($"{this.Name} {this.No} {this.Genre} {this.Count} {this.Price} {Genre}");
        }
    }
}
