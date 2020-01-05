using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesterCore.Model
{
    public class Test : Ratingable
    {
        /// <summary>
        /// Id теста
        /// </summary>
        [Key]
        public Guid TestId { get; set; }
        /// <summary>
        /// Id пользователя которому принадлежит вопрос
        /// </summary>
        [ForeignKey("OwnerID")]
        public Guid OwnerID { get; set; }
        /// <summary>
        /// Дата создание теста
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Описание теста
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// По какому предмету вопрос
        /// </summary>
        public Subject SubjectTest { get; set; }
        /// <summary>
        /// Тип теста
        /// </summary>
        public TestType TestType { get; set; }
        /// <summary>
        /// Пароль теста если есть
        /// </summary>
        public string Password { get; set; }

    }
}
