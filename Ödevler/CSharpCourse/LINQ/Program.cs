/*
 Linq (Language Integrated Query) bizim için bir sorgulama dilidir.
 Linq, veri tabanı sorgularını C# kodu içerisinde yazmamızı sağlar.
 .Where() metodu, içerisine yazılan koşula uyan verileri getirir.
 
 */

using LINQ;

List<Category> categories = new List<Category>
{
    new Category { CategoryID = 1, CategoryName = "Bilgisayar" },
    new Category { CategoryID = 2, CategoryName = "Telefon" }
};

List<Product> products = new List<Product>
{
    new Product { ProductID = 1, CategoryID = 1, ProductName = "Asus Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 10000, UnitsInStock = 5 },
    new Product { ProductID = 2, CategoryID = 1, ProductName = "Dell Laptop", QuantityPerUnit = "16 GB RAM", UnitPrice = 8000, UnitsInStock = 3 },
    new Product { ProductID = 3, CategoryID = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB RAM", UnitPrice = 6000, UnitsInStock = 2 },
    new Product { ProductID = 4, CategoryID = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB RAM", UnitPrice = 5000, UnitsInStock = 15 },
    new Product { ProductID = 5, CategoryID = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB RAM", UnitPrice = 8000, UnitsInStock = 0 }
};

foreach(var product in products)
{
    if(product.UnitPrice > 5000 && product.UnitsInStock > 3)
    {
        Console.WriteLine(product.ProductName);
    }
}
Console.WriteLine("---------------------");

var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

foreach(var product in result)
{
    Console.WriteLine(product.ProductName);
}

static List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredeProducts = new List<Product>();
    foreach (var product in products)
    {
        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
        {
            filteredeProducts.Add(product);
        }
    }

    return filteredeProducts;
}

static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
}