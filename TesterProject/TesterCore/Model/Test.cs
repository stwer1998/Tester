using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
