using System;
using System.ComponentModel.DataAnnotations;
using TesterCore.Dto;

namespace TesterCore.Model
{
    public class User
    {
        /// <summary>
        /// Id пользователя
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
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// День рождение
        /// </summary>
        public DateTime Birthday { get; set; }

        public User()
        {

        }

        public User(DtoRegister dtoRegister)
        {
            UserId = new Guid();
            Login = dtoRegister.Login;
            Password = dtoRegister.Password;
            Name = dtoRegister.Name;
            Surname = dtoRegister.Surname;
            RegisterDate = DateTime.Now;
            Birthday = dtoRegister.Birthday;
            
        }
    }
}
