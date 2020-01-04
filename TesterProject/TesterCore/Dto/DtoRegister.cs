using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesterCore.Dto
{
    public class DtoRegister:IValidatableObject
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина логина должна быть от 3 до 50 символов")]
        public string Login { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Длина пароля должна быть от 5 до 50 символов")]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (Birthday > DateTime.Now || Birthday < new DateTime(1940, 01, 01)) 
            {
                errors.Add(new ValidationResult("Укажите привильную дату", new List<string>() { "Birthday" }));
            }

            return errors;
        }
    }
}
