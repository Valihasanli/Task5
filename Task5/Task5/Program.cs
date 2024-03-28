namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book=new Book("dram", 12.3 , 2,"kitabadi",3);
            Book book1 = new Book("comedy", 15.5, 3, "obiri kitab", 5);
            Library library= new Library();
            library.AddBook(book);
            library.AddBook(book1);
            Console.WriteLine(library.GetFilteredBooks("dram"));

            library.ShowAllBooks();


        }
    }
}
