﻿//  Konstruktor vasitəsilə init propery-yə dəyər mənimsədirik.
Person person = new("Tom");
Console.WriteLine(person.Name); // Tom

public class Person
{
    public Person(string name) => Name = name;
    public string Name { get; init; }
}