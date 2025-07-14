using System.ComponentModel.DataAnnotations;

namespace MvcHelpersAndFilters.Models.Views
{
    public class AuthViewModel
    {
        [Display(Name = "Имя пользователя")]
        [Required(ErrorMessage = "Укажите имя пользователя")]
        [MinLength(2, ErrorMessage = "Имя пользователя слишком короткое")]
        [MaxLength(32, ErrorMessage = "Имя пользователя слишком длинное")]
        public string? UserName { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль")]
        [MinLength(3, ErrorMessage = "Пароль слишком короткий")]
        [MaxLength(64, ErrorMessage = "Пароль слишком длинный")]
        public string? Password { get; set; }
    }
}
