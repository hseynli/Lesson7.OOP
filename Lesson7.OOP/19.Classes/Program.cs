class MyClass
{
    public void Method()
    {
        Console.WriteLine("Hello world!");
    }
}

class Program
{
    static void Main()
    {
        // Weak reference
        new MyClass().Method();

        // Delay.
        Console.ReadKey();
    }
}