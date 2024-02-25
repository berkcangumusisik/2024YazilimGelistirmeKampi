using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
    List<GetAllBrandResponse> GetAll();
    
}
/**
 Veri tabanı nesneleri ile iş katmanı arasında bir köprü görevi gören servis katmanıdır.Kullanıcıdan alınan verileri iş katmanına iletir ve iş katmanından gelen verileri kullanıcıya iletir. Kullanıcı ihtiyacı olan verileri servis katmanı aracılığı ile alır.
 response : Kullanıcıya geri dönecek verileri içerir.
 request : Kullanıcıdan alınan verileri içerir.

responses(yanit) and requests(istek)
CreatedBrandResponse ekleme işlemi bittikten sonra kullanıcıya hangi modelin döneceğidir
CreateBrandRequest brand ise bir brand eklenecek kullanıcıdan bunun içindeki verlileri alıp kaydetmek için kullanılar bir model
CreatedBrandResponse(dönüş tipi marka oluşturma cevabı tipinde bir entity) Add(CreateBrandRequest brand)=> ekleme işlemi parametre olarak da marka oluşturma isteği tipinde bir entity istiyor;
Veri tabani nesnesini asla son kullanciya dondurmuyoruz veya istemiyoruz. Dtos olarak dosyasi kullanilir
 */
