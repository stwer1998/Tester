using System;
using System.ComponentModel.DataAnnotations;

namespace TesterCore.Model
{
    public class Answer
    {
        /// <summary>
        /// Id ответа
        /// </summary>
        [Key]
        public Guid AnswerId { get; set; }
        /// <summary>
        /// Id вопроса которому принадлежит ответ
        /// </summary>
        public Guid OwnerQuestionId { get; set; }
        /// <summary>
        /// Текст ответа
        /// </summary>
        public string AnswerVal { get; set; }
        /// <summary>
        /// Статус ответа правильность
        /// </summary>
        public bool Status { get; set; }
    }
}
