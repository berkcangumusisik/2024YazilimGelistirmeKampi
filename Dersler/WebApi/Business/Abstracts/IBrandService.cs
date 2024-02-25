using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    Brand Add(Brand brand);
    List<Brand> GetAll();
    
}
/**
 Veri tabanı nesneleri ile iş katmanı arasında bir köprü görevi gören servis katmanıdır.Kullanıcıdan alınan verileri iş katmanına iletir ve iş katmanından gelen verileri kullanıcıya iletir. Kullanıcı ihtiyacı olan verileri servis katmanı aracılığı ile alır.
 */
