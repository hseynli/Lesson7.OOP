Person tom = new Person();
tom.name = "Tom";
tom.Print();    // Person: Tom

//Konstanta field-lərə birbaşa klasın adı ilə müraciət edirik
Console.WriteLine(Person.type); // Person
                                // Person.type = "User";    // XƏTA - konstantanı dəyişmək olmaz!

class Person
{
    public const string type = "Person";
    public string name = "Undefined";
    public void Print() => Console.WriteLine($"{type}: {name}");
}