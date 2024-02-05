using System;
using Entities.Concrete; // Import the correct namespace for the Person class

public class Program
{
    static void Main(string[] args)
    {
        Variables();
        Hello();
        Hello("Berkcan");
        int result = Sum(2, 3);
        Console.WriteLine(result);

        // Arrays
        string[] students = new string[3];
        students[0] = "Berkcan";
        students[1] = "Engin";
        students[2] = "Kerem";

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }

        string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] cities2 = new string[cities1.Length];
        Array.Copy(cities1, cities2, cities1.Length);

        cities1[0] = "Adana";
        Console.WriteLine(cities2[0]); // Ankara

        int number1 = 10;
        int number2 = 20;
        number1 = number2;
        number2 = 30;
        Console.WriteLine(number2); // 30

        foreach (var item in cities2)
        {
            Console.WriteLine(item);
        }

        Citizen person1 = new Citizen();
        person1.Name = "Berkcan";
        person1.Surname = "Gümüşışık";
        person1.BirthYear = 1999;
        person1.IdentityNumber = 12345678910;

        // Use the Person class from the "Entities.Concrete" namespace
        Person person2 = new Person();
        person2.FirstName = "BERKCAN";
        person2.LastName = "GÜMÜŞIŞIK";
        person2.DateOfBirth = 1999;
        person2.NationalIdentity = 123456;
    }

    static void Hello(string name = "İsimsiz")
    {
        Console.WriteLine("Merhaba " + name);
    }

    static int Sum(int num1, int num2)
    {
        int res = num1 + num2;
        Console.WriteLine("Sonuç : " + res.ToString());
        return res;
    }

    static void Variables()
    {
        string message = "Merhaba";
        double amount = 100000;
        int number = 100;
        bool isTrue = true;

        string name = "Berkcan";
        string surname = "Gümüşışık";
        int birthYear = 1999;
        long identityNumber = 12345678910;

        Console.WriteLine(amount * 1.18);
    }
}

public class Citizen
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int BirthYear { get; set; }
    public long IdentityNumber { get; set; }
}
