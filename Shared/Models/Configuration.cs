namespace BlazorEComm.Shared.Models;

public class Configuration: Entity
{
    public Guid Id { get; set; }

    public string Key { get; set; } = string.Empty; 
    
    public string Value { get; set; } = string.Empty;

    public string Language { get; set; } = string.Empty;

    public bool Activ { get; set; } = true;
}