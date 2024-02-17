using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes;



public class Customer
{
    public int Id { get; set; } // Property
    //private string _firstName;
    //public string FirstName
    //{
    //    get { return "Mrs. " + _firstName; }
    //    set { _firstName = value; }
    //}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}

// prop : Property'leri temsil eder. Property'ler, nesnelerin özelliklerini (veri) tutarlar. prop tab tab yaparak otomatik olarak property oluşturabiliriz.

// get : Property'nin değerini okumak için kullanılır.
// set : Property'nin değerini değiştirmek için kullanılır.

// field : Field'ları temsil eder. Field'lar, nesnelerin özelliklerini (veri) tutarlar. Field'lar, property'lerin altında yatarlar. Field'lar, property'lerin get ve set metodları arasında kullanılır
