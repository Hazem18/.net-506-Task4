namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            //Adding books to the library

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            library.AddBook(new Book("1984", "George Orwell", "9780451524935")); //Can't add the same book twice

            //// Searching and borrowing books
            Console.WriteLine("\n\nSearching and borrowing books...");

            library.BorrowBook("The Great Gatsby");

            library.BorrowBook("1984");

            library.BorrowBook("1984"); // Can't borrow an already borrowed book

            library.BorrowBook("Harry Potter"); // This book is not in the library

            //// Returning books
            Console.WriteLine("\n\nReturning books...");

            library.ReturnBook("The Great Gatsby");

            library.ReturnBook("The Great Gatsby"); // Can't return an already avilable book

            library.ReturnBook("Harry Potter"); // This book is not borrowed


            //Search for a book
            Console.WriteLine("\n\nSearching books...");

            library.SearchBook("To Kill a Mockingbird"); // Found

            library.SearchBook("Harry Potter"); // Not Found


            //Remove books
            Console.WriteLine("\n\nRemove books...");

            library.RemoveBook("1984"); // Removed successfully

            library.RemoveBook("The Great Gatsby"); // Removed successfully

            library.RemoveBook("The Great Gatsby"); // Already removed

            library.RemoveBook("Harry Potter"); // Does not exist


            Console.ReadLine();


        }
    }
}
