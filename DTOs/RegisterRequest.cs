using System.ComponentModel.DataAnnotations;

public class RegisterRequest
{
    [Required(ErrorMessage = "UserName wajib diisi.")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Email wajib diisi.")]
    [EmailAddress(ErrorMessage = "Format email tidak valid.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Password wajib diisi.")]
    [MinLength(8, ErrorMessage = "Password harus memiliki setidaknya 8 karakter.")]
    public string? Password { get; set; }
}
