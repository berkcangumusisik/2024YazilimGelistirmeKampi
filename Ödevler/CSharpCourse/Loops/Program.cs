// for Döngüsü 
/*
 - for döngüsü ile belirli bir koşul sağlandığı sürece döngü çalışır. Verilen koşul sağlandığında döngü sonlanır.
for(veri_tipi değişken = başlangıç_değeri; koşul; artış_değeri){
    // döngü çalıştığında yapılacak işlemler
}
 */

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("****************");


// While Döngüsü
/*
 * - while döngüsü ile belirli bir koşul sağlandığı sürece döngü çalışır. Verilen koşul sağlandığında döngü sonlanır. Sonsuz döngü oluşturulmaması için döngü içerisindeki koşulun bir süre sonra false olmasına dikkat edilmelidir.
 while(koşul){
    // döngü çalıştığında yapılacak işlemler
 }
 */

int number = 100;
while(number >= 0)
{
    Console.WriteLine(number);
    number -= 5;
}
Console.WriteLine("****************");

// Do While Döngüsü
/** 
 * - Do while döngüsü ile belirli bir koşul sağlandığı sürece döngü çalışır. Verilen koşul sağlandığında döngü sonlanır. Sonsuz döngü oluşturulmaması için döngü içerisindeki koşulun bir süre sonra false olmasına dikkat edilmelidir. Do while döngüsü while döngüsünden farklı olarak döngü içerisindeki işlemler doğru olsun ya da olmasın en az bir kez çalışır.
 do{
     // döngü çalıştığında yapılacak işlemler
  }while(koşul);
*/

int number3 = 10;
do
{
    Console.WriteLine(number3);
    number3--;
}while(number3 >= 0);

Console.WriteLine("****************");

// Foreach Döngüsü
/*
- Foreach döngüsü dizilerde ve koleksiyonlarda kullanılır. Dizi ve koleksiyonlardaki elemanları tek tek döngü içerisinde kullanmak için kullanılır.
foreach(veri_tipi değişken in dizi){
    döngü çalıştığında yapılacak işlemler
}
*/

string[] students = new string[3] {"Engin", "Derin", "Berkcan"};
foreach (var student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine("****************");

// Break ve Continue
// Break => Döngüyü sonlandırır.
// Continue => Döngüyü bir sonraki adıma geçirir.

for(int i = 1; i <= 10; i++)
{
    if(i == 4)
        break;
    Console.WriteLine(i);
}

Console.WriteLine("****************");

for(int i = 1; i <= 10; i++)
{
    if(i == 4)
        continue;
    Console.WriteLine(i);
}

Console.WriteLine("****************");

if(IsPrimeNumber(7))
    Console.WriteLine("This is a prime number");
else
    Console.WriteLine("This is not a prime number");

static bool IsPrimeNumber(int number)
{
    if(number < 2)
        return false;
    for(int i = 2; i < number; i++)
    {
        if(number % i == 0)
            return false;
    }
    return true;
}

