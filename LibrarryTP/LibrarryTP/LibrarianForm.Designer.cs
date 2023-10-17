namespace LibrarryTP
{
    partial class LibrarianForm
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
            nameAdmin = new Label();
            dataGridViewEditableListUsers = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            dataGridViewEditableBookshelve = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditableListUsers).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditableBookshelve).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewEditableListUsers, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(786, 416);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(nameAdmin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 84);
            panel1.TabIndex = 0;
            // 
            // nameAdmin
            // 
            nameAdmin.AutoSize = true;
            nameAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameAdmin.Location = new Point(24, 21);
            nameAdmin.Name = "nameAdmin";
            nameAdmin.Size = new Size(44, 32);
            nameAdmin.TabIndex = 0;
            nameAdmin.Text = "***";
            // 
            // dataGridViewEditableListUsers
            // 
            dataGridViewEditableListUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEditableListUsers.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewEditableListUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditableListUsers.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author });
            dataGridViewEditableListUsers.Dock = DockStyle.Fill;
            dataGridViewEditableListUsers.Location = new Point(3, 93);
            dataGridViewEditableListUsers.Name = "dataGridViewEditableListUsers";
            dataGridViewEditableListUsers.RowTemplate.Height = 25;
            dataGridViewEditableListUsers.Size = new Size(780, 354);
            dataGridViewEditableListUsers.TabIndex = 1;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Имя";
            NameBook.Name = "NameBook";
            NameBook.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Дата рождения";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пользователи";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Книги";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewEditableBookshelve, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(786, 416);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 84);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(219, 32);
            label2.TabIndex = 0;
            label2.Text = "Имя пользователя";
            // 
            // dataGridViewEditableBookshelve
            // 
            dataGridViewEditableBookshelve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEditableBookshelve.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewEditableBookshelve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditableBookshelve.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewEditableBookshelve.Dock = DockStyle.Fill;
            dataGridViewEditableBookshelve.Location = new Point(3, 93);
            dataGridViewEditableBookshelve.Name = "dataGridViewEditableBookshelve";
            dataGridViewEditableBookshelve.RowTemplate.Height = 25;
            dataGridViewEditableBookshelve.Size = new Size(780, 354);
            dataGridViewEditableBookshelve.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Название";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Автор";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Год публикации";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "LibrarianForm";
            Load += LibrarianForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditableListUsers).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditableBookshelve).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label nameAdmin;
        private DataGridView dataGridViewEditableListUsers;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridViewEditableBookshelve;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
    }
}