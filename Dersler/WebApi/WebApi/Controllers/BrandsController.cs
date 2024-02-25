using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;
    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }
    [HttpPost]
    public IActionResult Add(CreateBrandRequest createdBrandRequest)
    {
       CreatedBrandResponse createdBrandResponse = _brandService.Add(createdBrandRequest);
        return Created("", createdBrandResponse);
       
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_brandService.GetAll());
    }

}

// HttpGet : Bir GET isteği alır. Veriyi okur.
// HttpPost : Bir POST isteği alır. Veriyi ekler.
// HttpPut : Bir PUT isteği alır. Veriyi günceller.
// HttpDelete : Bir DELETE isteği alır. Veriyi siler.

// 404 : Not Found : Kaynak bulunamadı
// 400 : Bad Request : Kötü istek
// 500 : Internal Server Error : Sunucu hatası
// 200 : OK : İşlem başarılı
// 201 : Created : Yeni bir kaynak oluşturuldu
// 401 : Unauthorized : Yetkisiz