
using LibrarryTP.Managers;
using LibrarryTP.Models;

namespace LibrarryTP
{
    public partial class AuthRegForm : Form
    {
        private User _user = new User { Name = "Артём", Password = "1234" };
        private User _librarian = new User { Name = "Артём", Password = "1234" };

        public AuthRegForm()
        {
            InitializeComponent();
        }

        private void buttonLoginAsUser_Click(object sender, EventArgs e)
        {
            var user = AuthRegManager.Authorize(_user.Name, _user.Password);
            if(user is null) user = AuthRegManager.Register(_user.Name, _user.Password);
            Hide();
            new MainForm(user).ShowDialog();
            Show();
        }

        private void buttonLoginAsLibrarian_Click(object sender, EventArgs e)
        {
            var user = AuthRegManager.Authorize(_librarian.Name, _librarian.Password);
            if (user is null) user = AuthRegManager.Register(_librarian.Name, _librarian.Password);
            Hide();
            new LibrarianForm(user).ShowDialog();
            Show();
        }

        private void AuthRegForm_Load(object sender, EventArgs e)
        {
            MainController.Manager = new DbManager();
            //MainController.AddBook(new Book { Name = "Отцы и дети", Author = "Тургенев", DateOfPublication = new DateTime(1862, 10, 10) });
            //MainController.AddBook(new Book { Name = "Мастер и Маргарита", Author = "Булгаков", DateOfPublication = new DateTime(1966, 10, 10) });
            //MainController.AddBook(new Book { Name = "Гарри Поттер и философский камень", Author = "Роулинг", DateOfPublication = new DateTime(1997, 10, 10) });
        }
    }
}
