using System.ComponentModel.DataAnnotations;

public class UserRegister
{
    [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
    [MinLength(6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Vui lòng xác nhận mật khẩu")]
    [Compare(nameof(Password), ErrorMessage = "Mật khẩu xác nhận không khớp")]
    public string ConfirmPassword { get; set; }
}
