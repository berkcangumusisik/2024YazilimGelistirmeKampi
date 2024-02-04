
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");
// Consol.WriteLine() ile ekrana yazı yazdırıyoruz.
// Tek satır yorum satırı
/* Çoklu satır yorum satırı
 *   1. satır
 *   2. satır
 *   3. satır
 */

string message1 = "Krediler";
int term = 36;
double amount = 100000.5;
bool isAunthenticated = true;

/**
 * Metinsel ifadeler "" içerisinde tanımlanır.
 * Değişken tanımlarken veriTürü değişkenAdı = değer; şeklinde tanımlanır.
 * Değişken : Programın çalışma zamanında değişebilen değerlerdir.
 * int : Tam sayı veri türüdür.
 * double : Ondalıklı sayı veri türüdür. .5 veya tam sayı olabilir.
 * bool : Mantıksal veri türüdür. true veya false değer alır.
 Variable : Değişken 
 * Değişken isimlendirirken camelCase kullanılır. İlk kelimenin baş harfi küçük, diğer kelimelerin baş harfi büyük olacak şekilde isimlendirilir.
 */

Console.WriteLine(message1);

// Karar Yapıları
if (isAunthenticated) // Eğer isAunthenticated true ise
{
    Console.WriteLine("Buton --> Hoşgeldin Berkcan");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yap.");
}


/**
 if(koşul)
 {
     // Koşul sağlandığında çalışacak kod bloğu
 }
 else
 {
     // Koşul sağlanmadığında çalışacak kod bloğu
 }
 */



// Eğer 500 kredi olsaydı yine mi bu şekilde yazacaktık? Tabii ki hayır. Dizi kullanarak daha az kod yazabiliriz.

string[] loans = new string[] { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" , "Kredi 6"}; // Db'den geliyormuş gibi düşünelim.

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";
//loans2[1] = "Kredi 2";
//loans2[2] = "Kredi 3";
//loans2[3] = "Kredi 4";
//loans2[4] = "Kredi 5";
//loans2[5] = "Kredi 6";



/**
 * Dizi tanımlarken veriTürü[] diziAdı = new veriTürü[] {değer1, değer2, değer3, ...}; şeklinde tanımlanır.
 * Dizi : Aynı veri türünden birden fazla değeri saklamak için kullanılır.
 * 2. yöntemde ise dizi tanımlanır ve her bir elemanı ayrı ayrı tanımlanır.
  veriTürü[] diziAdı = new veriTürü[elemanSayısı];
  diziAdı[0] = değer1;
  For döngüsü ile dizi elemanlarına erişim sağlanır. For döngüsü ile eleman sayısı kadar döngü oluşturulur ve her döngüde bir eleman işlenir.
    for(başlangıçDeğeri; koşul; artışMiktarı)
    {
        // Döngü içerisinde yapılacak işlemler
    }
    .Length : Dizi eleman sayısını verir.
  Programlama dillerinde diziler 0'dan başlar. Yani 1. eleman 0. index'tir.
 
 */


/*
 Entities : Varlık demektir. Örneğin; Müşteri, Kredi, Ürün, Kategori
 
 
 */

Course course1 = new Course(); // Course sınıfından course1 adında bir nesne oluşturduk. new : Bellekte bir alan oluşturur.
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8";
course1.Price = 0;


Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java 17";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12";
course3.Price = 20;


Course[] courses = new Course[] { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("------------------");
CourseManager courseManager = new CourseManager();
courseManager.GetAll();