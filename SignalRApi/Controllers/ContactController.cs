using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.DAL.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            //_mapper.Map =mapleyerek getir
            //neyi getir ? Bir liste getir <List>
            //bu liste bana neyi getirecek ? <ResultCategoryDto> getirecek
            //bunun kaynağı nerede olacak _categoryService'teki TGetListAll() etodu olacak
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        //bu yetiyor mu yetmiyor bi de bunun program.cs (business service yazılşınca orada olacak)
        //kısmında builderının geçilmesi gerekiyor


        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
            FooterDescription=createContactDto.FooterDescription,
            Location=createContactDto.Location,
            Mail=createContactDto.Mail,
            Phone= createContactDto.Phone
                

            });
            return Ok("İletişim Bilgisi Eklendi !");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi !");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactID=updateContactDto.ContactID,
                FooterDescription=updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                Mail=updateContactDto.Mail,
                Phone=updateContactDto.Phone
            });
            return Ok("İletişim Bilgisi Güncellendi !");

        }
    }
}
