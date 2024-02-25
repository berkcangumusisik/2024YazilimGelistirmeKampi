using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class BrandDal : IBrandDal
{
    List<Brand> _brands;
    public BrandDal()
    {
        _brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "Audi", CreatedDate=DateTime.Now },
            new Brand { Id = 2, Name = "BMW", CreatedDate=DateTime.Now },
            new Brand { Id = 3, Name = "Mercedes" , CreatedDate = DateTime.Now},
            new Brand { Id = 4, Name = "Volkswagen", CreatedDate = DateTime.Now },
            new Brand { Id = 5, Name = "Fiat" , CreatedDate = DateTime.Now}
        };
    }
    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }
}
