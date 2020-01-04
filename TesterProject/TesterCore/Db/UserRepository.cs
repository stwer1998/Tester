using System.Linq;
using TesterCore.Interfaces;
using TesterCore.Model;

namespace TesterCore
{
    public class UserRepository: IUserRepository
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
            if (user == null || user.Login != login) { return true; }
            else return false;
        }

        public User GetUser(string login, string password)
        {
            var user = db.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (user == null || user.Login != login) { return null; }
            else return user;
        }

        public void EditUser(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
        }
    }
}
