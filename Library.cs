using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKutuphane
{
    public class Library
    {

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int PageNumb { get; set; }
        public string Publisher { get; set; }
        public DateTime DateOfRegister { get; set; }

        static private int BookCount;
        static public int BookCount_
        {
            get
            {
                return BookCount;
            }
            set
            {
                BookCount = value;
            }
            
        }
        static Library()
        {
            BookCount = 0;
        }
        static public void DisplayBookNumber()
        {
            Console.WriteLine("Total Book's Number: " + BookCount);
        }


        public Library()
        {
            Console.WriteLine("Date of Registration : " + DateTime.Now);
        }
        public Library(string bookname, string authorname, string authorsurname, int pagenumber, string publisher) :this()

        {
            bookname = Name;
            authorname = AuthorName;
            authorsurname = AuthorSurname;
            pagenumber = PageNumb;
            publisher = Publisher;
        }
    }
}
