﻿using System.ComponentModel.DataAnnotations;

namespace BlazorEComm.Shared.Dtos;

public class UserLoginDto
{
    [Required, EmailAddress]
    public string Email { get;  set; } = string.Empty;

    [Required, DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
}