using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesterCore.Model
{
    public class Question
    {
        /// <summary>
        /// Id вопроса
        /// </summary>
        [Key]
        public Guid QuestionId { get; set; }
        /// <summary>
        /// Id теста которому принадлежит вопрос
        /// </summary>
        [ForeignKey("OwnerTestId")]
        public Guid OwnerTestId { get; set; }
        /// <summary>
        /// Тест которому пренадлежит вопрос
        /// </summary>
        public Test OwnerTest { get; set; }

        /// <summary>
        /// Тип овопроса(откратый или закрытый)
        /// </summary>
        public QuestionType QuestionType { get; set; }
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string QuestionVal { get; set; }
        /// <summary>
        /// Ответы теста
        /// </summary>
        public IEnumerable<Answer> Answers { get; set; }
    }
}
