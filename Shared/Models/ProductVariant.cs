﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorEComm.Shared.Models;

public class ProductVariant: Entity
{
    [JsonIgnore]
    public Product? Product { get; set; }
    
    public Guid ProductId { get; set; }
    
    public ProductType? ProductType { get; set; }
    
    public Guid ProductTypeId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal OriginalPrice { get; set; }

    public bool Visible { get; set; } = true;

    public bool Deleted { get; set; } = false;
}