﻿namespace WebUI.Dtos.BookingDtos
{
    public class UpdateBookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime BookingTime { get; set; }
    }
}
