using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ThucHanh3.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Không được bỏ trống tên")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có từ 4 đến 100 ký tự")]
        [Display(Name = "Tên")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Email")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", ErrorMessage = "Email phải có đuôi gmail.com")]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage ="Không được bỏ trống mật khẩu")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "Mật khẩu không hợp lệ")]
        [Display(Name = "Mật khẩu")]
        public string? Password {  get; set; }

        [Required(ErrorMessage ="Không được bỏ trống ngành")]
        [Display(Name = "Ngành")]
        public Branch? Branch { get; set;}

        [Required(ErrorMessage ="Không được bỏ trống giới tính")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }

        public bool IsRegular { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Không được bỏ trống địa chỉ")]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Không được bỏ trống ngày sinh")]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage ="Không được bỏ trống điểm")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        [Display(Name = "Điểm")]
        public double Diem { get; set; }
    }
}
