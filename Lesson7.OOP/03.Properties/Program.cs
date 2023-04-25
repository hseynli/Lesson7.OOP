class MyClass
{
    private string field = null;

    public string Field
    {
        set  // void SetField(string value)   -    metod-mutaror (setter)
        {
            field = value;
        }

        get  // string GetField()             -    metod-aksessor (getter)
        {
            return field;
        }
    }
}

class Program
{
    static void Main()
    {
        MyClass instance = new MyClass();

        instance.Field = "Hello world!";    // metod-mutaror

        Console.WriteLine(instance.Field);  // metod-aksessor

        // Delay.
        Console.ReadKey();
    }
}