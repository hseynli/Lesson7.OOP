//MyClass adlı klas yaradırıq
//Klasın daxilində string tipli public field və public Method adlı metod yaradırıq

class MyClass
{
    public string field;

    public void Method()
    {
        Console.WriteLine(field);
    }
}

class Program
{
    //Proqramın giriş hissəsi
    static void Main()
    {
        //MyClass klassının istance-nı yaradırıq. 
        //new açar sözü heap-da yeni obyekt yaradır.
        MyClass instance = new MyClass();
        instance.field = "Hello world!";
        Console.WriteLine(instance.field);

        instance.Method();

        Console.ReadKey();
    }
}