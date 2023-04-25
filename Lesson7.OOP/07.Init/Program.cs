Person person = new();
//person.Name = "Bob";    // XƏTA - inisalizasiya blokundan sonra dəyəri dəyişmək olmaz!

Console.WriteLine(person.Name); // Undefined
public class Person
{
    public string Name { get; init; } = "Undefined";
}