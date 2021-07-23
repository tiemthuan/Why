using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibs
{
    public class ManagerBook : List<Book>
    {
        Book b;
        public void AddBook(Book b)
        {          
            if (SearchBook(b.BookID) !=null)
            {
                Console.WriteLine("ID Duplicate");
                return;
                
            }
            else
            {
                this.Add(b);
                Console.WriteLine("Add Successful");
            }
            
            
            
        }

        public Book SearchBook(String ID)
        {
            foreach (Book item in this)
            {
                if (item.BookID.Equals(ID))
                {
                    return item;
                }
            }
            return null;
        }


        public void RemoveBook(String id)
        {           
        
                if (SearchBook(id) !=null)
                {
                this.Remove(SearchBook(id));
                    Console.WriteLine("Remove Successful");

                }
                else
                {
                    Console.WriteLine("Remove Fail!!");
                }
            
            
        }

        public Book SearchName(String name)
        {
            foreach (Book item in this)
            {
                if (item.BookName.Equals(name))
                {
                    return item;
                }
            }
            return null;
        }

        
    }
}
