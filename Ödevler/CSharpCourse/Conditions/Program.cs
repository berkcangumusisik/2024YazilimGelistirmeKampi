/*
 if(koşul)
 {
     // koşul sağlandığında çalışacak kodlar
 }
 else if(başka bir koşul)
 {
     // başka bir koşul sağlandığında çalışacak kodlar
 }
 else
 {
     // koşullar sağlanmadığında çalışacak kodlar
 }
 */

int number = 10;
if(number == 10)
{
    Console.WriteLine("Number is 10");
}
else if(number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}


// Single Line If : koşul ? doğruysa çalışacak kodlar : yanlışsa çalışacak kodlar
int number1 = 10;
Console.WriteLine(number1 == 10 ? "Number is 10" : "Number is not 10");


// Switch Case
/*
 switch(değişken)
 {
     case durum1:
         // durum1 sağlandığında çalışacak kodlar
         break;
     case durum2:
         // durum2 sağlandığında çalışacak kodlar
         break;
     default:
         // hiçbir durum sağlanmadığında çalışacak kodlar
         break;
 }
 */

int number2 = 10;
switch(number2)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

if(number >= 10 && number <= 20)
{
    Console.WriteLine("Number is between 10 and 20");
}
else if(number >= 20 && number <= 30)
{
    Console.WriteLine("Number is between 20 and 30");
}
else if(number > 200 || number < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200 ");
}


if(number < 100)
{
    if(number >= 90 && number < 95)
    {
        Console.WriteLine("Number is between 90 and 95");
    }
    else if(number >= 95 && number < 100)
    {
        Console.WriteLine("Number is between 95 and 100");
    }
}

// || => veya anlamına gelir. Herhangi bir koşul sağlanırsa çalışır.
// && => ve anlamına gelir. Tüm koşullar sağlanırsa çalışır.
