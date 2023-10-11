using LibrarryTP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarryTP.Managers
{
    public class DbManager
    {
        Contexts.AppContextDb Context { get; set; }
        public string Path { get; set; } = "Data Source=mylibrary.db";

        public DbManager()
        {
            Context = new Contexts.AppContextDb();
            Context.Path = Path;
            Context.Database.EnsureCreated();
            Context.Users.Load();
            Context.Books.Load();
            CreateAdmin();
        }

        private void CreateAdmin()
        {
            if (Context.Users.FirstOrDefault(x => x.Role == 0) == null)
                AddUser(new User { Name = "admin", Password = "admin", Role = 0 });
        }

        public User GetAdmin() => Context.Users.FirstOrDefault(x => x.Role == 0);

        public IEnumerable<User> GetUsers() => Context.Users;

        public IEnumerable<Book> GetBooks() => Context.Books;

        public void AddUser(User user)
        {
            Context.Users.Add(user);
            SaveChanges();
        }

        public void RemoveUser(User user)
        {
            Context.Users.Remove(user);
            SaveChanges();
        }

        public void AddBook(Book book)
        {
            Context.Books.Add(book);
            SaveChanges();
        }

        public void RemoveOperation(Book book)
        {
            Context.Books.Remove(book);
            SaveChanges();
        }

        public void SaveChanges() => Context.SaveChanges();
    }
}
