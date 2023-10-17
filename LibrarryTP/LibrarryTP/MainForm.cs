using LibrarryTP.Managers;
using LibrarryTP;
using LibrarryTP.Models;

namespace LibrarryTP
{
    public partial class MainForm : Form
    {
        private User _user;

        public MainForm(User user)
        {
            _user = user;
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nameUser.Text = _user.Name;
            UpdateView();
        }

        private void UpdateView()
        {
            dataGridViewBookshelve.Rows.Clear();
            foreach (var book in MainController.GetAllBooks().Reverse())
                dataGridViewBookshelve.Rows.Add(book.Name, book.Author, book.DateOfPublication);
        }
    }
}