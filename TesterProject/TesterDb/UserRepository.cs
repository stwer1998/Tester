using System.Linq;
using TesterCore.Models;

namespace TesterDb
{
    public class UserRepository
    {
        private MyDbContext db;
        public UserRepository(MyDbContext db)
        {
            this.db = db;
        }

        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public bool CheckLogin(string login)
        {
            var user = db.Users.FirstOrDefault(x => x.Login == login);
            if (user == null || user.Login != login) { return false; }
            else return true;
        }

        public User GetUser(string login, string password)
        {
            var user = db.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (user == null || user.Login != login) { return null; }
            else return user;
        }
    }
}
