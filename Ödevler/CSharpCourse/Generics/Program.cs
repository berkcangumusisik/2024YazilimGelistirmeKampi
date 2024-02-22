List<string> cities = new List<string>();
cities.Add("New York");
cities.Add("London");
cities.Add("Istanbul");
cities.Add("Sydney");
Console.WriteLine(cities.Count);

MyList<string> cities2 = new MyList<string>();
cities2.Add("New York");
cities2.Add("London");
cities2.Add("Istanbul");
cities2.Add("Sydney");
Console.WriteLine(cities2.Count);
class MyList<T>
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T value)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = value;
    }
    public int Count
    {
        get { return _array.Length; }
    }
    
}
/*
 T : Tip parametresi oluşturur. Bu parametre, sınıfın içinde kullanılan tüm tipleri temsil eder.
 */