using static System.Reflection.Metadata.BlobBuilder;

namespace C42_G01_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q02
            Book NewBook01 = new Book("123456789", "Harry Potter", ["J.K. Rowling"], DateTime.Now, 750);
            Book NewBook02 = new Book("111222333", "And Then They Were None", ["Agatha Christie"], DateTime.Now, 1000);
            Book NewBook03 = new Book("012345678", "The Cuckoo's Calling", ["Robert Galbraith"], DateTime.Now, 600);

            List<Book> books = new List<Book>() { NewBook01, NewBook02, NewBook03 };
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            DisplayBooks GetISBN = delegate (Book B) { return B.ISBN.ToString(); };
            LibraryEngine.ProcessBooks(books, GetISBN);

            DisplayBooks GetPublicationDate = B => B.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(books, GetPublicationDate);
            #endregion

            Console.WriteLine(LibraryEngine.Exist(books, (b => b.ISBN == "123456789")));
            Console.WriteLine(LibraryEngine.Find(books, (b => b.ISBN == "012345678")));
            Console.WriteLine(LibraryEngine.FindIndex(books, (b => b.ISBN == "111222333")));

        }
    }
}
