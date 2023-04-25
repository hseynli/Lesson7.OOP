class Author
{
    // Auto-Property. 
    public string Name { get; set; }
    public string Book { get; set; }
}
class Program
{
    static void Main()
    {
        Author author1 = new Author()
        {
            Name = "Jeffrey Richter",            // İnisializasiya bloku.
            Book = "CLR via C#"
        };

        Author author2 = new Author              // () mötərizələri buraxırıq
        {
            Name = "Steve McConnell",            // İnisializasiya bloku..
            Book = "Code Complete"
        };

        Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
        Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

        // Delay.
        Console.ReadKey();
    }
}