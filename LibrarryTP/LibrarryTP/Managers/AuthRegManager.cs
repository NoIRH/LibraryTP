using LibrarryTP.Models;
using System.Data;

namespace LibrarryTP.Managers
{
    public static class AuthRegManager
    {
        public static User Authorize(string login, string password)
        {
            return MainController.Manager.GetUsers().Where(u => u.Name == login && u.Password == password).FirstOrDefault();
        }

        public static User Register(string login, string password)
        {
            if (MainController.Manager.GetUsers().Where(u => u.Name == login && u.Password == password).Count() != 0)
                new DuplicateNameException();
            User user = new User() { Name = login, Password = password };
            MainController.Manager.AddUser(user);
            return user;
        }
    }
}
