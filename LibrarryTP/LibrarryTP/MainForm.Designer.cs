namespace LibrarryTP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            nameUser = new Label();
            dataGridViewBookshelve = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            YearOfPublication = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookshelve).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewBookshelve, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(nameUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 84);
            panel1.TabIndex = 0;
            // 
            // nameUser
            // 
            nameUser.AutoSize = true;
            nameUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameUser.Location = new Point(19, 22);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(219, 32);
            nameUser.TabIndex = 0;
            nameUser.Text = "Имя пользователя";
            // 
            // dataGridViewBookshelve
            // 
            dataGridViewBookshelve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBookshelve.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewBookshelve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookshelve.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, YearOfPublication });
            dataGridViewBookshelve.Dock = DockStyle.Fill;
            dataGridViewBookshelve.Location = new Point(3, 93);
            dataGridViewBookshelve.Name = "dataGridViewBookshelve";
            dataGridViewBookshelve.RowTemplate.Height = 25;
            dataGridViewBookshelve.Size = new Size(794, 354);
            dataGridViewBookshelve.TabIndex = 1;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Название";
            NameBook.Name = "NameBook";
            NameBook.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // YearOfPublication
            // 
            YearOfPublication.HeaderText = "Год публикации";
            YearOfPublication.Name = "YearOfPublication";
            YearOfPublication.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "_";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookshelve).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label nameUser;
        private DataGridView dataGridViewBookshelve;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn YearOfPublication;
    }
}