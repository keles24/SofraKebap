﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DTOLayer.BookingDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService,IMapper mapper)
        {
            _mapper = mapper;
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking
            {
                Mail = createBookingDto.Mail,
                Name = createBookingDto.Name,
                BookingTime = createBookingDto.BookingTime,
                PersonCount = createBookingDto.PersonCount,
                PhoneNumber = createBookingDto.PhoneNumber,
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon oluşturuldu.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking
            {
                Mail = updateBookingDto.Mail,
                Name = updateBookingDto.Name,
                BookingTime = updateBookingDto.BookingTime,
                PersonCount = updateBookingDto.PersonCount,
                PhoneNumber = updateBookingDto.PhoneNumber,
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon güncellendi.");
        }

    }
}
