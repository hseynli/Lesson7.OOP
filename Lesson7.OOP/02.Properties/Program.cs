class MyClass
{
    private string field = null;

    public void SetField(string value) // metod-mutaror (setter)
    {
        field = value;
    }

    public string GetField()           // metod-aksessor (getter)
    {
        return field;
    }
}

class Program
{
    static void Main()
    {
        MyClass instance = new MyClass();

        instance.SetField("Hello world!");     // metod-mutator

        string @string = instance.GetField();  // metod-aksessor

        Console.WriteLine(@string);

        // Delay.
        Console.ReadKey();
    }
}