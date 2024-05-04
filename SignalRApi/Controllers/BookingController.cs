﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Yapıldı !");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
          var value=  _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                BookingID = updateBookingDto.BookingID,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                Date = updateBookingDto.Date
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi !");
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value=_bookingService.TGetById(id);
            return Ok(value);
        }
        //bu işlemi tamamladıktan sonra program.cs (daha sonra Businesse serviste olacak bu kısım) de registirationunu yapmam lazım 
    }
}
