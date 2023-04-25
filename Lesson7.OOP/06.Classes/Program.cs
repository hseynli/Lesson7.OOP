class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
}

class Program
{
    static void Main()
    {
        //Sadəcə new() açar sözündən istifadə edərək instance yarada bilərik.
        Person person = new(); // new Person();

        // Delay.
        Console.ReadKey();
    }
}