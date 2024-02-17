Person[] people = new Person[3]
{
    new Customer{ID=1, FirstName="Ali", LastName="Veli", City="Ankara"},
    new Student{ID=2, FirstName="Ayşe", LastName="Fatma", Department="Computer Science"},
    new Person{ID=3, FirstName="Hayri", LastName="Kemal"}
};

foreach (var person in people)
{
    Console.WriteLine(person.FirstName);
}


class Person
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}


/*
 Inheritance(Kalıtım)
- Bir sınıfın başka bir sınıftan türetilmesi işlemine denir.
- Türetilen sınıf, türeten sınıfın özelliklerini ve metotlarını miras alır.
- Türetilen sınıf, türeten sınıfın özelliklerini ve metotlarını kullanabilir.

 */