using System.ComponentModel.DataAnnotations;

namespace TesterCore.Dto
{
    public class DtoAnswer
    {
        [Required(ErrorMessage = "Не указано ответ")]
        public string Answer { get; set; }

        public bool Status { get; set; }
    }
}
