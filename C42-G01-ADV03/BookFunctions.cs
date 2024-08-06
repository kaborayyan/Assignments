using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV03
{    
    internal class BookFunctions
    {
        #region Q02
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            StringBuilder authors = new StringBuilder();
            if (B.Authors != null)
            {
                foreach (string name in B.Authors)
                {
                    authors.Append($"{name} ");
                }
            }
            return authors.ToString();
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
        #endregion
    }
}
