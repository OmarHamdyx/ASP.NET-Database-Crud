﻿namespace DatabaseApi.Models
{
    public class Nationality
    {
        public int? NationalityId { get; set; }
        public string? NationalityName { get; set; }
        public Person? Person { get; set; } 

    }
}
