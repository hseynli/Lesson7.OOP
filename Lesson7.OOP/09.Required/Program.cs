Person tom = new Person() { Name = "Test", Age = 23 };  // Əgər mənimsətməsək - XƏTA
public class Person
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}