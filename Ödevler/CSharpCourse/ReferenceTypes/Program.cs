// Değer Tipler : int, decimal, float, double, bool tipi gibi veri tipleridir. Değer tipleri stack'te tutulur. Bu yüzden değer tiplerde bir değişiklik yapıldığında diğer değişkenler etkilenmez.
int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 30;
Console.WriteLine(number1); // 20 Burada number1 değişkeni number2 değişkenine eşitlenmişti. Bu yüzden number1 değişkeni 20 olarak çıktı verir. 


// Reference Tipler : Array, Class, Interface, String gibi veri tipleridir. Reference tipleri heap'te tutulur. Bu yüzden reference tiplerde bir değişiklik yapıldığında diğer değişkenler etkilenir.
int[] numbers1 = new int[] { 1, 2, 3 };
int[] numbers2 = new int[] { 10, 20, 30 };
numbers1 = numbers2;
numbers2[0] = 1000;
Console.WriteLine(numbers1[0]); // 1000 Burada numbers1 değişkeni numbers2 değişkenine eşitlenmişti. Bu yüzden numbers1 değişkeni 1000 olarak çıktı verir.

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Berkcan";
person2 = person1;
person1.FirstName = "Derin";
Console.WriteLine(person2.FirstName); // Derin Burada person1 değişkeni person2 değişkenine eşitlenmişti. Bu yüzden person2 değişkeni Derin olarak çıktı verir.

Customer customer = new Customer();
customer.FirstName = "Salih";
Person person3 = customer;
Console.WriteLine(person3.FirstName); // Salih Burada customer nesnesi person nesnesine eşitlendi. Bu yüzden person3.FirstName çıktısı Salih olarak verir.

Console.WriteLine(((Customer)person3).CreditCardNumber); // null Burada person3 nesnesi Customer tipine cast edildi. Bu yüzden CreditCardNumber çıktısı null olarak verir.

PersonManager personManager = new PersonManager();
personManager.Add(customer); // Salih Burada personManager nesnesi Add metodu ile customer nesnesini çağırdı. Bu yüzden Salih çıktısı verir.




class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}


class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}