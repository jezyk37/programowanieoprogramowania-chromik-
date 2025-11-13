namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = DateTime.Now;
            Book book = new Book(datetime, "Stanisław Len", "Solaris");
            Console.ReadKey();
        }
    }
}

public class Book
{
    private string author;
    private string title;
    private DateTime releaseDate;

    public Book(string author, string title)
    {
        this.author = author;
        this.title = title;
        Console.WriteLine("Constructor 1");
    }

    public Book(DateTime releaseDate, string author, string title) : this(author, title) 
    {
        this.releaseDate = releaseDate;
        Console.WriteLine("Constructor 2");
    }
}