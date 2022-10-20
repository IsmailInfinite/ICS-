using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Book

{

    struct Books

    {

        private string title, author, subject;

        private int book;

        public void Values()

        {

            Console.Write("Book Name : ");
            title = Console.ReadLine();

            Console.Write("Author : ");
            author = Console.ReadLine();

            Console.Write("Subject : ");
            subject = Console.ReadLine();

            Console.Write("Id : ");
            book = Convert.ToInt32(Console.ReadLine());

        }



        public void Display()

        {

            Console.WriteLine("Book Title : {0}\nAuthor Name : {1}\nSubject : {2}\nId : {3}", title, author, subject, book);

        }

    }



    class TestStructures

    {

        static void Main(string[] args)

        {

            Books books = new Books();
            books.Values();
            books.Display();
            Console.ReadKey();

        }

    }

}


