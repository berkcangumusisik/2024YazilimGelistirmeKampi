using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class Course
{
    // ID : Bir nesnenin benzersiz kimliğidir.
    public int Id { get; set; } // property - özellik
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}

// prop yazıp tab yaparak otomatik property oluşturabiliriz.