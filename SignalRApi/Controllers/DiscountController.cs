using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.DAL.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {

        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            //_mapper.Map =mapleyerek getir
            //neyi getir ? Bir liste getir <List>
            //bu liste bana neyi getirecek ? <ResultCategoryDto> getirecek
            //bunun kaynağı nerede olacak _categoryService'teki TGetListAll() etodu olacak
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        //bu yetiyor mu yetmiyor bi de bunun program.cs (business service yazılşınca orada olacak)
        //kısmında builderının geçilmesi gerekiyor


        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                ImageUrl = createDiscountDto.ImageUrl,
                Title = createDiscountDto.Title


            });
            return Ok("İndirim Bilgisi Eklendi !");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim Bilgisi Silindi !");
        }
        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
               Amount = updateDiscountDto.Amount,
               Description = updateDiscountDto.Description,
               ImageUrl = updateDiscountDto.ImageUrl,
               Title = updateDiscountDto.Title,
               DiscountID = updateDiscountDto.DiscountID
            });
            return Ok("İndirim Bilgisi Güncellendi !");

        }
    }
}
