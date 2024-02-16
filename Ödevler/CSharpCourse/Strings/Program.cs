string city = "Ankara";
Console.WriteLine(city[0]); // => A

foreach (var item in city)
{
    Console.WriteLine(item);
}

Console.WriteLine("************");

string city2 = "İstanbul";
Console.WriteLine("{0} {1}", city, city2);

string sentence = "My name is Berkcan Gümüşışık";
Console.WriteLine(sentence.Length); // => 26 .Length => Dizinin uzunluğunu verir.
bool result = sentence.StartsWith("My"); // => true .StartsWith => Dizinin belirtilen karakterle başlayıp başlamadığını kontrol eder.
bool result2 = sentence.EndsWith("k"); // => false .EndsWith => Dizinin belirtilen karakterle bitip bitmediğini kontrol eder.
var result3 = sentence.IndexOf("name"); // => 3 .IndexOf => Dizinin belirtilen karakterin indexini verir.
var result4 = sentence.LastIndexOf(" "); // => 21 .LastIndexOf => Dizinin belirtilen karakterin son indexini verir.
var result5 = sentence.Insert(0, "Hello, "); // => Hello, My name is Berkcan Gümüşışık .Insert => Dizinin belirtilen indexine belirtilen karakteri ekler.
var result6 = sentence.Substring(3, 4); // => name .Substring => Dizinin belirtilen index aralığındaki karakterleri alır.
var result7 = sentence.ToLower(); // => my name is berkcan gümüşışık .ToLower => Dizinin tüm karakterlerini küçük harfe çevirir.
var result8 = sentence.ToUpper(); // => MY NAME IS BERKCAN GÜMÜŞIŞIK .ToUpper => Dizinin tüm karakterlerini büyük harfe çevirir.
var result9 = sentence.Replace(" ", "-"); // => My-name-is-Berkcan-Gümüşışık .Replace => Dizinin belirtilen karakterlerini belirtilen karakterle değiştirir.
var result10 = sentence.Remove(2, 5); // => My is Berkcan Gümüşışık .Remove => Dizinin belirtilen index aralığındaki karakterleri siler.
