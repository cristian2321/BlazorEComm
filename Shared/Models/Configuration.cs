using System.ComponentModel.DataAnnotations;

namespace BlazorEComm.Shared.Models;

public class Configuration: Entity
{
    public Guid Id { get; set; }
   
    [Required, MaxLength(256)]
    public string Key { get; set; } = string.Empty;
   
    [Required, MaxLength(256)]
    public string Value { get; set; } = string.Empty;
   
    [Required, MaxLength(256)]
    public string Type { get; set; } = string.Empty;

    [Required, MaxLength(256)]
    public string Language { get; set; } = string.Empty;

    public bool Activ { get; set; } = true;

    public bool Deleted { get; set; } = false;
}