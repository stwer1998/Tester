using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesterCore.Model
{
    public class Comment
    {
        /// <summary>
        /// Ключ соментарии
        /// </summary>
        [Key]
        public Guid CommentId { get; set; }
        /// <summary>
        /// Ключ к тесту
        /// </summary>
        public Guid TestId { get; set; }
        /// <summary>
        /// Тест которому оставлен коментарии
        /// </summary>
        public Test Test { get; set; }
        /// <summary>
        /// Ключ к пользователю
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Пользователь который оставил коментарию
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Текст коментарии
        /// </summary>
        public string Text { get; set; }
    }
}
