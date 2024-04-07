using System.ComponentModel.DataAnnotations;

namespace Solar_Watch.Contracts;

public record RegistrationRequest(
    [Required]string Email, 
    [Required]string Username, 
    [Required]string Password);