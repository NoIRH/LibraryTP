using LibrarryTP.Managers;
using LibrarryTP.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarryTP
{
    public partial class LibrarianForm : Form
    {
        private User _user;
        BindingList<User> Users { get; set; } = new BindingList<User>();
        BindingList<Book> Books { get; set; } = new BindingList<Book>();

        public LibrarianForm(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void UpdateViewBooks()
        {
            dataGridViewEditableBookshelve.Rows.Clear();
            foreach (var book in MainController.GetAllBooks().Reverse())
                Books.Add(book);
            dataGridViewEditableBookshelve.DataSource = Books;
            dataGridViewEditableBookshelve.Columns["Id"].Visible = false;
            dataGridViewEditableBookshelve.Columns[1].HeaderText = "Название";
            dataGridViewEditableBookshelve.Columns[2].HeaderText = "Автор";
            dataGridViewEditableBookshelve.Columns[3].HeaderText = "Дата публикации";
        }

        private void UpdateViewUsers()
        {
            dataGridViewEditableListUsers.Rows.Clear();
            foreach (var user in MainController.GetAllUsers().Reverse())
                Users.Add(user);
            dataGridViewEditableListUsers.DataSource = Users;
            dataGridViewEditableListUsers.Columns["Role"].Visible = false;
            dataGridViewEditableListUsers.Columns["Id"].Visible = false;
            dataGridViewEditableListUsers.Columns[1].HeaderText = "Имя читателя";
            dataGridViewEditableListUsers.Columns[2].HeaderText = "Фамилия";
            dataGridViewEditableListUsers.Columns[3].HeaderText = "Пароль";
            dataGridViewEditableListUsers.Columns[4].HeaderText = "Дата рождения";
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
            MainController.UpdateBooks(Books);
        }

        private void buttonUserSave_Click(object sender, EventArgs e)
        {
            MainController.UpdateUsers(Users);
        }
    }
}