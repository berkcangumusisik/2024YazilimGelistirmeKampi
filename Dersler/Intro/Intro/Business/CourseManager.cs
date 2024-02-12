using Intro.DataAccess.Abstract;
using Intro.DataAccess.Concrete;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //Dependency Injection : Bağımlılık Enjeksiyonu : Bir sınıfın başka bir sınıfa bağımlı olması durumunda, bağımlılığın dışarıdan verilmesi prensibidir.
    private readonly ICourseDal _courseDal; // readonly : sadece okunabilir. Değer ataması yapıldıktan sonra değiştirilemez. Constructor'da değer ataması yapılabilir.
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
    {
        // Veri kaynağından çekilir.
        return _courseDal.GetAll();
    }
}

/*
 ctor yazıp tab tab yaparak constructor oluşturabiliriz.
Constructor : Bir sınıfın instance'ı oluşturulduğunda çalışan bloktur. Yapıcı blok. new'lediğimizde çalışır.

Global : Genel, evrensel, küresel demektir. Her yerden erişilebilir demektir.
Local : Yerel demektir. Sadece tanımlandığı blok içerisinde erişilebilir demektir.
 */