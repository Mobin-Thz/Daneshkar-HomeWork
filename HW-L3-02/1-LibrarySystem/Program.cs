namespace _1_LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book csharpInNutshell = new Book(
                title: "csharpInNutshell",
                author: "Joseph_Albahari",
                ISBN: 235754633528);

            Book cleanArchitecture = new Book(
                title: "cleanArchitecture",
                author: "Robert_Martin",
                ISBN: 2836475826473);

            Library programmingLibrary = new Library(name: "programmingLibrary");
            programmingLibrary.AddBook(csharpInNutshell);
            //programming.AddBook(cleanArchitecture);

            foreach (var book in programmingLibrary.books)
            {
                Console.WriteLine($"title: {book.title}");
            }

            programmingLibrary.BorrowBook(cleanArchitecture);
            programmingLibrary.BorrowBook(csharpInNutshell);
            programmingLibrary.BorrowBook(csharpInNutshell);



            Console.ReadKey();

        }

        class Book
        {
            public string title { get; set; }
            public string author { get; set; }
            public long ISBN { get; set; }
            public bool isAvailable { get; set; } = true;
            public Book(string title, string author, long ISBN)
            {
                this.title = title;
                this.author = author;
                this.ISBN = ISBN;

            }


        }

        class Library
        {
            public string LibraryName { get; set; }

            public List<Book> books = new List<Book>();
            public Library(string name)
            {
                this.LibraryName = name;
            }

            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine($"The book {book.title} added to {this.LibraryName}");

            }

            public void BorrowBook(Book book)
            {
                if (books.Contains(book))
                {
                    if(book.isAvailable == true)
                    {
                        Console.WriteLine($"You have borrowed the book: {book.title}");
                        book.isAvailable = false;

                    }
                    else
                    {
                        Console.WriteLine($"The book {book.title} is not available.");
                    }
                }
                else
                {
                    Console.WriteLine($"Sorry! \n There is no such book with name: \"{book.title}\" in this library.");
                }
            }

            public void ReturmBook(Book book)
            {
                book.isAvailable = true;
            }
        }
    }
}
