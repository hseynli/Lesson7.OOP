Person tom = new Person("Tom");
Console.WriteLine(tom.name);

//tom.name = "Sam"; // XƏTA - dəyişmək olmaz
class Person
{
    public readonly string name = "Undefined"; // bu şəkildə mənimsətmək olar
    public Person(string name)
    {
        this.name = name; // həmçinin konstruktorda da readonly tipli field-lərə dəyər mənimsətmək olar
    }

    public void ChangeName(string otherName)
    {
        //this.name = otherName;    // OLMAZ!!!
    }
}