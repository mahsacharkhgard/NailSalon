﻿using Reservation.Application.Contract.IServices.Users;

namespace Reservation.EndPoint.API.Securities
{
    public class UserContext : IUserContext
    {
        public string UserId { get; set; }
    }
}
