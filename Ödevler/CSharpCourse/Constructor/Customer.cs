using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor;


public class Customer
{
    public Customer()
    {
        Console.WriteLine("Yapıcı Blok Çalıştı");
    }

    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}

/*
 Constructor (Yapıcı Metot) Nedir?
- Constructor, bir sınıfın örneğini oluşturduğumuzda çalışan metotlardır.
- Kod başlangıcında çalışan metotlardır.
- Default constructor, parametre almayan constructor'dır.
- Constructor'lar, sınıfın ismi ile aynı olmalıdır.
 */