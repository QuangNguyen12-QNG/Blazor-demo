using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu mới")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Vui lòng xác nhận mật khẩu")]
        public string ConfirmPassword { get; set; }
    }
}
