using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Library
    {
        public List<Book> books = new List<Book>();

        public Library() { }
        public bool IsEmpty (List <Book> bs)
        {
            if (bs.Count == 0)
                return true;
            else
                return false;
        }
        public bool IsFound (string title)
        {
            bool found = false;
            if (IsEmpty (books))
                return found;
            
            for (int i = 0; i < books.Count; i++)
            {
                if (title == books[i].title)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
        public void AddBook (Book book)
        {
            if (IsFound(book.title))
                Console.WriteLine($"{book.title} by {book.author} already exists.");
            else
            {
                books.Add(book);
                Console.WriteLine($"{book.title} by {book.author} Added successfully.");
            }

        }
        public void RemoveBook (string title)
        {
            int index = 0;
            if (IsEmpty(books))
                Console.WriteLine("There are no books in the library already");
            else
            {
                if(IsFound(title))
                {
                    for (int i = 0; i<books.Count; i++)
                    {
                        if (title == books[i].title)
                        {
                            index = i;
                            break;
                        }
                    }
                    books.RemoveAt(index);
                    Console.WriteLine($"The {title} book was removed successfully");
                }
                else
                    Console.WriteLine($"The {title} book doesn't exist");
            }
        }

        public void BorrowBook(string title)
        {
            int index = 0;
            if (IsEmpty(books))
                Console.WriteLine("There are no books in the library currently");
            else
            {
                if (IsFound(title))
                {
                    for (int i = 0; i<books.Count; i++)
                    {
                        if (title == books[i].title)
                        {
                            index = i;
                            break;
                        }
                    }
                    if (books[index].availability == true)
                    {
                        books[index].availability = false;
                        Console.WriteLine($"You just borrowed the {title} book successfully");
                        Console.WriteLine("You should return the book within 7 days at max");
                    }
                    else
                        Console.WriteLine($"The {title} book is already borrowed, it's NOT available currently");
                }
                else
                    Console.WriteLine($"The {title} book doesn't exist");

            }
        }
        public void ReturnBook (string title)
        {
            int index = 0;
            if (IsEmpty(books))
                Console.WriteLine("There are no books in the library currently");
            else
            {
                if (IsFound(title))
                {
                    for (int i = 0; i<books.Count; i++)
                    {
                        if (title == books[i].title)
                        {
                            index = i;
                            break;
                        }
                    }
                    if (books[index].availability == false)
                    {
                        books[index].availability = true;
                        Console.WriteLine($"The {title} book is returned successfully");
                    }
                    else
                        Console.WriteLine($"The {title} book is NOT borrowed");
                }
                else
                    Console.WriteLine($"The {title} book doesn't exist");

            }
        }

       public void SearchBook(string title)
        {
            if (IsEmpty(books))
                Console.WriteLine("There are no books in the library currently");
            else
            {
                if (IsFound(title))
                    Console.WriteLine($"The {title} book is found");
                else
                    Console.WriteLine($"The {title} book is NOT found");
            }
       }
    }
}
