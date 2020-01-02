using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesterCore.Model
{
    public class User
    {
        /// <summary>
        /// Iльзователя
        /// </summary>
        [Key]
        public Guid UserId { get; set; }
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// пароль пользователя
        /// </summary>
        public string Password { get; set; }
    }
}
