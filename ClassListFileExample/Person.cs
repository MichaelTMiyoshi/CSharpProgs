using System;
using System.Security.Cryptography;

namespace ClassListFileExample;

public class Person
{
    private String name;
    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private int height; // inches
    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    private int weight; // pounds
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private String phone;
    public String Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public Person()
    {
        name = "";
        age = 0;
        height = 0;
        weight = 0;
        phone = "";
    }

    public Person(String name, int age, int height, int weight, String phone)
    {
        this.name = name;
        this.age = age;
        this.height = height;
        this.weight = weight;
        this.phone = phone;
    }

    public override string ToString()
    {
        // String output = $"{name, -12} age: {age,4}, height: {height, 5}, weight: {weight, 5}, phone: {phone}";
        // return output;
        // {name,-12} puts the name in a 12 character output field left justified (-)
        return $"{name,-12} age: {age,4}, height: {height,4}, weight: {weight,5}, phone: {phone}";
    }
}
