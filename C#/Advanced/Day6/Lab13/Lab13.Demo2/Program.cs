namespace Lab13.Demo2
{
    internal delegate string mydel(Book b);
    internal class Program
    {
        static void Main(string[] args)
        {
            mydel d1;
            d1 = (b) => { return b.ISBN; }; // anonymous
            Book B1 = new Book("123", "C# Programming", new string[] { "Tom", "Jerry" }, new DateTime(2010, 1, 1), 100);
            Book B2 = new Book("124", "Java Programming", new string[] { "Tom", "Jerry" }, new DateTime(2010, 1, 1), 100);
            Book B3 = new Book("125", "Python Programming", new string[] { "Tom", "Jerry" }, new DateTime(2010, 1, 1), 100);
            List<Book> books = new List<Book>(4);
            books.Add(B1);
            books.Add(B2);
            books.Add(B3);
            // cast from delegate to func
            LibraryEngine.ProcessBooks(books, new Func<Book, string>(d1));
            d1 = b => b.PublicationDate.ToString(); // lambda 
            LibraryEngine.ProcessBooks(books, new Func<Book, string>(d1));
            // cast from func to delegate
            Func<Book, string> F1 = (b) => { return b.ISBN; };
            LibraryEngine.ProcessBooks(books, new mydel(F1));
            mydel d2 = new mydel(BookFunctions.GetTitle); // pass function to constructor
            LibraryEngine.ProcessBooks(books, d2);


        }
    }
}
