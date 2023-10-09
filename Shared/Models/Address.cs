using System.ComponentModel.DataAnnotations;

namespace BlazorEComm.Shared.Models;

public class Address: Entity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    [Required, StringLength(256)]
    public string FirstName { get; set; } = string.Empty;

    [Required, StringLength(256)]
    public string LastName { get; set; } = string.Empty;

    [Required, StringLength(256)]
    public string Street { get; set; } = string.Empty;

    [Required, StringLength(256)]
    public string City { get; set; } = string.Empty;

    [Required, StringLength(256)]
    public string Region { get; set; } = string.Empty;

    [Required, StringLength(10), DataType(DataType.PostalCode)]
    public string PostalCode { get; set; } = string.Empty;

    [Required, StringLength(256)]
    public string Country { get; set; } = string.Empty;

    public bool Principal { get; set; }
}
