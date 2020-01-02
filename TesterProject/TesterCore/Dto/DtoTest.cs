using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TesterCore.Model;

namespace TesterCore.Dto
{
    public class DtoTest: IValidatableObject
    {
        public List<Question> Questions { get; set; }

        public Subject Subject { get; set; }

        public TestType TestType { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (Questions.Count < 1) 
            {
                errors.Add(new ValidationResult("Нельзя создавать тест без вопроса", new List<string>() { "Questions" }));
            }

            return errors;
        }
    }
}
