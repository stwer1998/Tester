using System.ComponentModel.DataAnnotations;

namespace TesterCore.Dto
{
    public class DtoUser
    {
        [Required(ErrorMessage = "Не указано логин")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина логина должна быть от 3 до 50 символов")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указано пароль")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Длина пароля должна быть от 4 до 50 символов")]
        public string Password { get; set; }
    }
}
