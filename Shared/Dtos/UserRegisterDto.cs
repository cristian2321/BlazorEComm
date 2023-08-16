using System.ComponentModel.DataAnnotations;

namespace BlazorEComm.Shared.Dtos;

public class UserRegisterDto
{
    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required, DataType(DataType.Password), StringLength(256, MinimumLength = 8)]
    public string Password { get; set; } = string.Empty;

    [DataType(DataType.Password), Compare(nameof(Password), ErrorMessage = "The password do not match")]
    public string ConfirmPassword { get; set; } = string.Empty;
}