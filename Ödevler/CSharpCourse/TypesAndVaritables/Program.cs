// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Console.WriteLine(); => Ekrana yazı yazdırmak için kullanılır.,
// Console.ReadLine(); => Kullanıcıdan veri almak için kullanılır.

// Value Types => int, float, double, decimal, char, bool, byte, short, long
// int ile sayısal değerler tutulur.
int number1 = 10;
Console.WriteLine("Number1 is {0}", number1); 

// long ile büyük sayısal değerler tutulur.
long number2 = 1000000000000000000;
Console.WriteLine("Number2 is {0}", number2);

// short ile küçük sayısal değerler tutulur.
short number3 = 10000;
Console.WriteLine("Number3 is {0}", number3);

// byte ile 0-255 arasındaki sayısal değerler tutulur.
byte number4 = 255;
Console.WriteLine("Number4 is {0}", number4);

// bool ile true veya false değerleri tutulur.
bool condition = true;
Console.WriteLine("Condition is {0}", condition);

// char ile tek karakter tutulur. '' içerisine yazılır.
char character = 'A';
Console.WriteLine("Character is {0}", character);

// string ile metinsel değerler tutulur. "" içerisine yazılır.
string text = "Hello World!";
Console.WriteLine("Text is {0}", text);

// double ile ondalıklı sayısal değerler tutulur.
double number5 = 5.5;
Console.WriteLine("Number5 is {0}", number5);

// decimal ile ondalıklı sayısal değerler tutulur. m harfi ile tanımlanır. 
decimal number6 = 5.5m;
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine((int)Days.Friday);

enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

