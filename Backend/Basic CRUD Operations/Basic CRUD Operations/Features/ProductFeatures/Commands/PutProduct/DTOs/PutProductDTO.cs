﻿using System.ComponentModel.DataAnnotations;

namespace Basic_CRUD_Operations.Features.ProductFeatures.Commands.PutProduct.DTOs
{
    public class PutProductDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        public string? Description { get; set; }
        public string? Brand { get; set; }
        public IFormFile? Image { get; set; }
        [Required]
        public float Quantity { get; set; }
    }
}
