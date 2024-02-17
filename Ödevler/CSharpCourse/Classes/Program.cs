using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();


Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Berkcan";
customer.LastName = "Gümüşışık";
customer.City = "Ankara";



Customer customer2 = new Customer
{
    Id = 2, FirstName = "Derin", LastName = "Demiroğ", City = "İstanbul"
};


// class : Sınıfları temsil eder. Sınıflar, nesnelerin özelliklerini ve davranışlarını tanımlar.

// New : Yeni bir nesne oluşturmak için kullanılır. 