using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV03
{
    public class Book
    {
        #region Q01
        // Properties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        // Methods
        public override string ToString()
        {
            StringBuilder authors = new StringBuilder();
            if (Authors != null)
            {
                foreach (string name in Authors)
                {
                    authors.Append($"{name} ");
                }
            }
            
            return $"Book: ISBN = {ISBN}, Title = {Title}, Authors = {authors.ToString()}, Publication Date = {PublicationDate}, Price = {Price}";
        }
        #endregion

    }
}
