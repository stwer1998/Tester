using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TesterCore.Model;

namespace TesterCore.Dto
{
    public class Question: IValidatableObject
    {
        [Required(ErrorMessage ="Вопрос не может быть путым")]
        public string QuestionVal { get; set; }

        public QuestionType QuestionType { get; set; }

        public List<Answer> Answers { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Answers.Count < 1) 
            {
                errors.Add(new ValidationResult("Не указан правильный ответ",new List<string>() {"Asnwers"}));
            }

            return errors;
        }
    }
}
