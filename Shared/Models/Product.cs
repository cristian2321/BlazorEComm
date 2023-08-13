﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEComm.Shared.Models;

public class Product
{
    public Guid Id { get; set; }
   
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public Guid CategoryId { get; set; }
   
    [ForeignKey(nameof(CategoryId))]
    public Category? Category { get; set; }

    public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
}