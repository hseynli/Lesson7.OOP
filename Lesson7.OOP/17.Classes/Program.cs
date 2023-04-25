﻿Person p = new Person { name = "Tom", age = 23 };
ChangePerson(p);

Console.WriteLine(p.name); // Alice
Console.WriteLine(p.age); // 23

void ChangePerson(Person person)
{
    // dəyəri dəyişəcək
    person.name = "Alice";
    // ancaq bu metod daxilində işləyəcək
    person = new Person { name = "Bill", age = 45 };
    Console.WriteLine(person.name); // Bill
}

class Person
{
    public string name = "";
    public int age;
}