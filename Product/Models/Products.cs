﻿using System.ComponentModel.DataAnnotations;

namespace Product.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }


    }
}
