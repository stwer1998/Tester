using System;
using System.ComponentModel.DataAnnotations;

namespace TesterCore.Model
{
    public class TestHistory
    {
        /// <summary>
        /// Id история теста
        /// </summary>
        [Key]
        public Guid TestHistoryId { get; set; }
        /// <summary>
        /// Id пользователя который рещил тест
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// пользователь родитель
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Id теста который решен
        /// </summary>
        public Guid TestId { get; set; }
        /// <summary>
        /// Процент правильных ответов
        /// </summary>
        public double Point { get; set; }
    }
}
