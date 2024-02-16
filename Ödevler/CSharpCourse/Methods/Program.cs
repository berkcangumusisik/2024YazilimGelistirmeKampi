// Metotlar => Tekrar tekrar kullanılabilirliği sağlar. 

Add();
int result = Add2(10, 20);
Console.WriteLine(result);

int number1 = 10;
int number2 = 20;
int result2 = Add3(out number1, number2);
Console.WriteLine(result2);

Console.WriteLine(Add4(1,2,3,4,5,6,7,8,9,10));
Console.WriteLine(Add4(1,12,15,18,20,25,30,35,40,45,50));


static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int number1, int number2 = 30)
{
    int result = number1 + number2;
    return result;
}

static int Add3(out int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

// Method Overloading
static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

static int Add4(int number, params int[] numbers)
{
    return numbers.Sum();
}


/*
 static => metotların sınıf adı olmadan kullanılmasını sağlar.
 void => metotların geriye değer döndürmediğini belirtir.
 static void FonksiyonAdı()
{
    // Fonksiyonun içerisine yazılacak kodlar
}

FonksiyonAdı(); => Fonksiyonu çağırmak için kullanılır.


return => metotların geriye değer döndürmesini sağlar. Fonksiyonun içerisinde return ile belirtilen değer geriye döner. Üzerinde return olmayan metotlar void olarak belirtilir. Return ile belirtilen değer metotun geriye döndüreceği değeri belirtir. Geri döndürmenin gereksinimi üzerinde işlem yapılacaksa return kullanılır.

Default parametre : Metotlara parametre gönderilirken parametrelerin varsayılan değerlerini belirlemek için kullanılır. Eğer metoda parametre gönderilmezse varsayılan değer kullanılır. Varsayılan değerler metot imzasında belirtilen parametrelerin en sonuna yazılır. Varsayılan değerlerin belirtilmesi ile metot çağrıldığında parametrelerin gönderilmesi zorunlu olmaz.

out ve ref : Metotlara parametre gönderilirken parametrelerin referans tip olarak gönderilmesini sağlar. out ve ref ile gönderilen parametreler metot içerisinde değiştirilebilir. out ve ref arasındaki fark out ile gönderilen parametreler metot içerisinde ilk değer atanmazken ref ile gönderilen parametreler metot içerisinde ilk değer atanır. out ve ref ile gönderilen parametreler metot içerisinde değiştirilirken metot dışında da değişir.

Method Overloading : Aynı isimde farklı parametreler alan metotların tanımlanmasına denir. Aynı isimde farklı parametreler alan metotlar tanımlanırken metotların imzaları farklı olmalıdır. Metotların imzaları metot adı ve parametrelerin sayısı ve türüne göre belirlenir

params : Metotlara değişken sayıda parametre gönderilmesini sağlar. params ile belirtilen parametreler metot imzasında en son parametre olarak belirtilir. params ile belirtilen parametreler metot çağrıldığında dizi olarak gönderilir. params ile belirtilen parametreler metot içerisinde dizi olarak kullanılır.
 */