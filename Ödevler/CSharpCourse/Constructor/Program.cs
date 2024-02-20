using Constructor;

Customer customer1 = new Customer
{
    Id = 1,
    FirstName = "Ali",
    LastName = "Veli",
    City = "Ankara"
};


Customer customer2 = new Customer(2, "Ayşe", "Fatma", "İstanbul");

Console.WriteLine(customer2.Id);
Console.WriteLine(customer2.FirstName);
Console.WriteLine(customer2.LastName);
Console.WriteLine(customer2.City);

Customer customer3 = new Customer();
customer3.Id = 3;
