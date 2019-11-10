using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class Book
{
    private string title;
    private string author;
    private string publisher;
    private DateTime releaseDate;
    private string isbn;
    private decimal price;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }

    public DateTime ReleaseDate
    {
        get { return releaseDate; }
        set { releaseDate = value; }
    }

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public Book(string title, string author, string publisher, DateTime releaseDate, string ISBN, decimal price)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        ReleaseDate = releaseDate;
        this.ISBN = ISBN;
        Price = price;
    }
}

class Library
{
    private string name;
    private List<Book> books;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Book> Books
    {
        get { return books; }
        set { books = value; }
    }

    public Library(string name)
        : this(name, new List<Book>())
    {
    }

    public Library(string name, List<Book> books)
    {
        Name = name;
        Books = books;
    }
}

class BookLibrary
{
    static void Main(string[] args)
    {
        Library library = new Library("lib");
        SortedSet<string> authors = new SortedSet<string>();

        using (StreamReader reader = new StreamReader("../../Test.txt"))
        {
            int numberOfBooks = int.Parse(reader.ReadLine());

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] bookParams = reader.ReadLine().Split(' ');

                string title = bookParams[0];
                string author = bookParams[1];
                string publisher = bookParams[2];
                DateTime releaseDate = DateTime.ParseExact(bookParams[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string ISBN = bookParams[4];
                decimal price = decimal.Parse(bookParams[5]);

                Book book = new Book(title, author, publisher, releaseDate, ISBN, price);

                library.Books.Add(book);
                authors.Add(author);
            }
        }

        using (StreamWriter writer = new StreamWriter("../../Output.txt"))
        {
            foreach (string author in authors.OrderByDescending(a => library.Books.Where(book => book.Author == a).Sum(book => book.Price)))
            {
                decimal totalPrice = library.Books.Where(a => a.Author == author).Sum(book => book.Price);

                writer.WriteLine($"{author} -> {totalPrice:f2}");
            }
        }
    }
}