using LibrarryTP.Managers;
using LibrarryTP.Models;

namespace LibrarryTP
{
    public partial class LibrarianForm : Form
    {
        private User _user;

        public LibrarianForm(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void UpdateViewBooks()
        {
            dataGridViewEditableBookshelve.Rows.Clear();
            foreach (var book in MainController.GetAllBooks().Reverse())
                dataGridViewEditableBookshelve.Rows.Add(book.Name, book.Author, book.DateOfPublication);
        }

        private void UpdateViewUsers()
        {
            dataGridViewEditableListUsers.Rows.Clear();
            foreach (var user in MainController.GetAllUsers().Reverse())
                dataGridViewEditableListUsers.Rows.Add(user.Name, user.DateBirth.ToString());
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            nameAdmin.Text = _user.Name;
            adminName2.Text = _user.Name;
            UpdateViewBooks();
            UpdateViewUsers();
        }

        private void buttonBookSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserSave_Click(object sender, EventArgs e)
        {

        }
    }
}