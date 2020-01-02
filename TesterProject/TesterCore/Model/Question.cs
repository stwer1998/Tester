using System;
using System.Collections.Generic;
using System.Text;

namespace TesterCore.Model
{
    public class Question
    {
        /// <summary>
        /// Id вопроса
        /// </summary>
        public Guid QuestionId { get; set; }
        /// <summary>
        /// Id теста которому принадлежит вопрос
        /// </summary>
        public Guid OwnerTestId { get; set; }
        /// <summary>
        /// Тип овопроса(откратый или закрытый)
        /// </summary>
        public QuestionType QuestionType { get; set; }
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string QuestionVal { get; set; }
    }
}
