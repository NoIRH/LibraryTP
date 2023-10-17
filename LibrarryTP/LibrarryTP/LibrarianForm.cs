using LibrarryTP.Managers;
using LibrarryTP.Models;

namespace LibrarryTP
{
    public partial class LibrarianForm : Form
    {
        private User _user;

        public LibrarianForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UpdateViewBooks()
        {
            dataGridViewEditableBookshelve.Rows.Clear();
            foreach (var book in MainController.GetOperationsAllBooks().Reverse())
                dataGridViewEditableBookshelve.Rows.Add(book.Name, book.Author, book.DateOfPublication);
        }

        private void UpdateViewUsers()
        {
            dataGridViewEditableListUsers.Rows.Clear();
            foreach (var user in MainController.GetOperationsAllUsers().Reverse())
                dataGridViewEditableListUsers.Rows.Add(user.Name, user.DateBirth.ToString());
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            nameAdmin.Text = _user.Name;
            UpdateViewBooks();
            UpdateViewUsers();
        }
    }
}