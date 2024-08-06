using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace C42_G01_ADV03
{
    // Delegate
    public delegate string DisplayBooks(Book B);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist, DisplayBooks reference)
        {
            foreach (Book book in blist)
            {
                Console.WriteLine(reference(book));
            }
        }

        // Exist Method
        public static bool Exist(List<Book> blist, Predicate<Book> exist)
        {
            foreach (Book book in blist)
            {
                if (exist(book))
                {
                    return true;
                }
            }
            return false;
        }
        
        // Find Method
        public static Book Find(List<Book> blist, Predicate<Book> find)
        {
            foreach (Book book in blist)
            {
                if (find(book))
                {
                    return book;
                }
            }
            return null; // حاسس ان كده غلط بس الكومبيلر قبلها
        }

        // FindIndex
        public static int FindIndex(List<Book> blist, Predicate<Book> findindex)
        {
            for (int i = 0; i < blist.Count; i++)
            {
                if (findindex(blist[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
