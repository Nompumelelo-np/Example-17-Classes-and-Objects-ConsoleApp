using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_17_Classes_and_Objects_ConsoleApp
{
    internal class Book //Book is the name of the class
    {
        //Fields, give desciption of the class 
        public string title;
        public string author;
        public int pages;
        static void Main(string[] args)
        { 
            //book1 is a "variable"/object of the class
            Book book1 = new Book();

            //methods- gives indepth description of the variables assigned
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Talkein";
            book2.pages = 200;

            Console.WriteLine("book2 has " + book2.pages + " pages" + ".");
            Console.WriteLine("The tile of book1 is " + book1.title + "!");

            Console.ReadLine();

        }
    }
}
