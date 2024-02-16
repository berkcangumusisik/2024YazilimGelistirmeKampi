/*
 Diziler (Arrays)
- Aynı türdeki verileri saklamak için kullanılır.
- Dizilerin boyutu sabittir.
- Dizilerin boyutu tanımlandığında belirtilir.
- Dizilerin boyutu değiştirilemez.
Dizi Tanımlama
- Dizi tanımlanırken veri tipi ve dizi adı belirtilir.
- Dizi tanımlanırken boyutu belirtilir.
veri_tipi[] dizi_adi = new veri_tipi[boyut];
- Dizi tanımlanırken boyutu belirtilmezse boyutu 0 olur.
 */

string[] students = new string[3];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Berkcan";

string[] students2 = new string[3] {"Engin", "Derin", "Berkcan"};

foreach (var student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine("************");
// 2 Boyutlu Diziler 
// Tanımlama : veri_tipi[,] dizi_adi = new veri_tipi[satır, sütun];

string[,] regions = new string[5, 3]
{
    {"İstanbul", "İzmit", "Balıkesir"},
    {"Ankara", "Konya", "Kırıkkale"},
    {"Antalya", "Adana", "Mersin"},
    {"Rize", "Trabzon", "Samsun"},
    {"İzmir", "Muğla", "Manisa"}
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("************");
}

// GetUpperBound(0) => 0. boyutun son indexini verir.
// GetUpperBound(1) => 1. boyutun son indexini verir.
// 2 boyutlu dizilerde 0. boyut satır, 1. boyut sütun olarak düşünülebilir.
// 3 boyutlu dizilerde 0. boyut satır, 1. boyut sütun, 2. boyut ise derinlik olarak düşünülebilir.

