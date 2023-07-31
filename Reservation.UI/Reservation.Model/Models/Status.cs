﻿namespace Reservation.Model.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
