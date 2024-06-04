﻿namespace BackEnd.Models.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
