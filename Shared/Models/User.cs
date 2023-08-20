namespace BlazorEComm.Shared.Models;

public class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public byte[] PasswordHash { get; set; } = default!;

    public byte[] PasswordSalt { get; set; } = default!;

    public DateTime DateCreated { get; set; } = DateTime.Now;

    public List<Address> Addresses { get; set; } = new();
}