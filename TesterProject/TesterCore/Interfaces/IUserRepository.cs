using System;
using System.Collections.Generic;
using System.Text;
using TesterCore.Model;

namespace TesterCore.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Если есть пользователь с таким Login и Password то вернет User
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User GetUser(string login, string password);
        /// <summary>
        /// Добавления пользователя в базу данных
        /// </summary>
        /// <param name="organizer"></param>
        void AddUser(User user);
        /// <summary>
        /// Проверякт можно ли использовать логином если есть вернет false
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        bool CheckLogin(string login);
    }
}
