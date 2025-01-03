using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Demo2
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            return B.ISBN;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
}
