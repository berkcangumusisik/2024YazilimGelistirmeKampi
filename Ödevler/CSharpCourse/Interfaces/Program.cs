using Interfaces;

PersonManager personManager = new PersonManager();
Customer customer = new Customer
{
    Id = 1,
    FirstName = "Berkcan",
    LastName = "Gümüşışık",
    Address = "Ankara"
};

personManager.Add(customer);

Student student = new Student
{
    Id = 1,
    FirstName = "Berkcan",
    LastName = "Gümüşışık",
    Departmant = "Computer Science"
};

personManager.Add(student);

//CustomerManager customerManager = new CustomerManager();
//customerManager.Add(new SqlServerCustomerDal());


ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}


class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get ; set ; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }
}


class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}



/*
 - Interface bizim için bir şablon görevi görür.
 - Interface içerisinde sadece metotlar, özellikler, eventler ve indexler tanımlanabilir.
 - Interface içerisinde tanımlanan metotlar, özellikler, eventler ve indexlerin gövdeleri olmaz.
 - I interface isimleri ile başlar.
 - new'lenemezler.
Polymorphism (Çok biçimlilik) : Bir nesnenin farklı tiplerde kullanılabilmesidir. Bu sayede kodun daha esnek ve genişletilebilir olmasını sağlar.
 */

