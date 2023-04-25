// Klasın instance-nın metodun arqumentinə göndərilməsi
class MyClass
{
    public void Method()
    {
        Console.WriteLine("MyClass klasinin metodu cagirilib");
    }
}

class MyClass2
{
    // Aşağıdkı sətirdə CallMethod adlı metod yaradırıq. Metod MyClass tipli arqument qəbul edir və geriyə heç nə qaytamır.
    public void CallMethod(MyClass my)
    {
        // CallMethod metodunun daxilində my arqumentinin Method adlı metodunu çağırırıq
        my.Method();
    }
}

class Program
{
    static void Main()
    {
        MyClass my = new MyClass();

        MyClass2 my2 = new MyClass2();

        my2.CallMethod(my);

        // Задержка
        Console.ReadKey();
    }
}