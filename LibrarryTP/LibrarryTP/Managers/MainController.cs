using LibrarryTP.Models;

namespace LibrarryTP.Managers
{
    public static class MainController
    {
        private static DbManager _manager;

        public static DbManager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        public static IEnumerable<Book> GetOperationsAllBooks() => _manager.GetBooks();

        public static IEnumerable<User> GetOperationsAllUsers() => _manager.GetUsers();

        public static  void UpdateUsers(IEnumerable<User> users)
        {
            _manager.RemoveAllUsers();
            foreach (var item in users)
             _manager.AddUser(item);
        }

        public static void UpdateBooks(IEnumerable<Book> books)
        {
            _manager.RemoveAllUsers();
            foreach (var item in books)
                _manager.AddBook(item);
        }

        public static void AddUser(User user)
        {
            _manager.AddUser(user);
        }

        public static void AddBook(Book book)
        {
            _manager.AddBook(book);
        }
    }
}
