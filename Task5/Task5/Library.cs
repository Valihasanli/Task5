using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Library
    {
        Book[] Books = { };
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
           
        }
        public  void ShowAllBooks()
        {for (int i = 0; i < Books.Length; i++) { Console.WriteLine(Books[i].ShowInfo);}//hamisini voidle yazmali idim duzeldecem
            
        }
        public Book[] GetFilteredBooks(string genre)
        {
            Book[] books = { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Array.Resize(ref books, books.Length + 1);
                    books[books.Length - 1] = Books[i];
                }
                
            }
            return books;
        }
        public Book[] GetFilteredBooksPrice(int minPrice,int maxPrice)
        {
            Book[] books = { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice && (Books[i].Price<=maxPrice))
                {
                    Array.Resize(ref books, books.Length + 1);
                    books[books.Length - 1] = Books[i];
                }
            }
            return books;
        }
    }
}
