﻿using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class User
    {
       
        public int Id { get; set; }
        public string? Username { get; set; }
    }
}
