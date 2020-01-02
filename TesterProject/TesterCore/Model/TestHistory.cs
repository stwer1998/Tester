using System;
using System.Collections.Generic;
using System.Text;

namespace TesterCore.Model
{
    public class TestHistory
    {
        /// <summary>
        /// Id история теста
        /// </summary>
        public Guid TestHistoryId { get; set; }
        /// <summary>
        /// Id пользователя который рещил тест
        /// </summary>
        public Guid OwnerUserId { get; set; }
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
