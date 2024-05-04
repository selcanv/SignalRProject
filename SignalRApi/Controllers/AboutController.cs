using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        //böylece bağımlılığımı azalttım aboutservis içindeki metotlarıma erişim sağlıyor olacağım

        [HttpGet]
         public IActionResult AboutList()
        {
            var values=_aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl
            };
            //insert işlemi,
            _aboutService.TAdd(about);
            return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Eklendi !");
        }
        [HttpDelete("{id}")]
        //id ye göre ilme işlemi yapılacak
        public IActionResult DeleteAbout(int id)
        {
            //id ye göre bul
            var value = _aboutService.TGetById(id);
            //bulduktan sonra valueden gelen değeri sil
            _aboutService.TDelete(value);
            return Ok("Hakkımda Alanı Silindi !");

        }
        //bunlar test kısmı için 
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID = updateAboutDto.AboutID,
                ImageUrl = updateAboutDto.ImageUrl,
                Description = updateAboutDto.Description,
                Title = updateAboutDto.Title
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda Alanı Güncellendi !");
        }

        //id ye göre getirme işlemi için
        //api de aynı attribute aynı formatta birden fazla kez kullanıldığında hata veriyor
        //hata vermemesi için bir isim verdim "GetAbout" diye
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value=  _aboutService.TGetById(id);
            return Ok(value);
        }
        

    }
}
