﻿using System;

var person = new Person() { Name = "Sam" };
Console.WriteLine(person.Name);     // Sam
Console.WriteLine(person.Email);    // Sam@gmail.com
public class Person
{
    string name = "";
    public string Name
    {
        get { return name; }
        init
        {
            name = value;
            Email = $"{value}@gmail.com";
        }
    }
    public string Email { get; init; } = "";
}