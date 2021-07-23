using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibs;
namespace Start
{
    class Client
    {
        static void Main(string[] args)
        {   int choice;
            ManagerBook m = new ManagerBook();
            do
            {
                Console.WriteLine("****_MENU YOUR OPTION_****");
                Console.WriteLine("1. Add a book.");
                Console.WriteLine("2. Remove a book.");
                Console.WriteLine("3. Find a book");
                Console.WriteLine("Other. EXIT");
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter BookID: ");
                        String BookID = Console.ReadLine();
                        Console.WriteLine("Enter BookName: ");
                        String BookName = Console.ReadLine();
                        Console.WriteLine("Enter Author: ");
                        String Author = Console.ReadLine();
                        Console.WriteLine("Enter Publisher: ");
                        String Publisher = Console.ReadLine();
                        Book b = new Book(BookID, BookName, Author, Publisher);
                        m.AddBook(b);
                        break;
                    case 2:
                        String ID;
                        Console.WriteLine("Enter ID you want remove: ");
                        ID = Console.ReadLine();
                        m.RemoveBook(ID);                       
                        break;
                    case 3:
                        String name;
                        Console.WriteLine("Enter name book: ");
                        name = Console.ReadLine();
                        if (m.SearchName(name) != null)
                        {
                            Console.WriteLine("FOUNDED!!");
                        }
                        else
                        {
                            Console.WriteLine("NOT FIND!!");
                        }

                        break;
                    default:
                      
                        break;
                }
            }
            while (choice <= 3);
        }
    }
}
