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
            buttonUserSave = new Button();
            nameAdmin = new Label();
            dataGridViewEditableListUsers = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            buttonBookSave = new Button();
            adminName2 = new Label();
            dataGridViewEditableBookshelve = new DataGridView();
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
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(900, 559);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUserSave);
            panel1.Controls.Add(nameAdmin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 112);
            panel1.TabIndex = 0;
            // 
            // buttonUserSave
            // 
            buttonUserSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUserSave.Location = new Point(768, 20);
            buttonUserSave.Margin = new Padding(2);
            buttonUserSave.Name = "buttonUserSave";
            buttonUserSave.Size = new Size(113, 70);
            buttonUserSave.TabIndex = 1;
            buttonUserSave.Text = "Сохранить изменения";
            buttonUserSave.UseVisualStyleBackColor = true;
            buttonUserSave.Click += buttonUserSave_Click;
            // 
            // nameAdmin
            // 
            nameAdmin.AutoSize = true;
            nameAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameAdmin.Location = new Point(27, 28);
            nameAdmin.Name = "nameAdmin";
            nameAdmin.Size = new Size(57, 41);
            nameAdmin.TabIndex = 0;
            nameAdmin.Text = "***";
            // 
            // dataGridViewEditableListUsers
            // 
            dataGridViewEditableListUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEditableListUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewEditableListUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditableListUsers.Dock = DockStyle.Fill;
            dataGridViewEditableListUsers.Location = new Point(2, 122);
            dataGridViewEditableListUsers.Margin = new Padding(2);
            dataGridViewEditableListUsers.Name = "dataGridViewEditableListUsers";
            dataGridViewEditableListUsers.RowHeadersVisible = false;
            dataGridViewEditableListUsers.RowHeadersWidth = 62;
            dataGridViewEditableListUsers.RowTemplate.Height = 33;
            dataGridViewEditableListUsers.Size = new Size(896, 437);
            dataGridViewEditableListUsers.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 600);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(906, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пользователи";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(906, 567);
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
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(900, 559);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonBookSave);
            panel2.Controls.Add(adminName2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 112);
            panel2.TabIndex = 0;
            // 
            // buttonBookSave
            // 
            buttonBookSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBookSave.Location = new Point(745, 19);
            buttonBookSave.Margin = new Padding(2);
            buttonBookSave.Name = "buttonBookSave";
            buttonBookSave.Size = new Size(138, 70);
            buttonBookSave.TabIndex = 2;
            buttonBookSave.Text = "Сохранить изменения";
            buttonBookSave.UseVisualStyleBackColor = true;
            buttonBookSave.Click += buttonBookSave_Click;
            // 
            // adminName2
            // 
            adminName2.AutoSize = true;
            adminName2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            adminName2.Location = new Point(24, 30);
            adminName2.Name = "adminName2";
            adminName2.Size = new Size(271, 41);
            adminName2.TabIndex = 0;
            adminName2.Text = "Имя пользователя";
            // 
            // dataGridViewEditableBookshelve
            // 
            dataGridViewEditableBookshelve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEditableBookshelve.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewEditableBookshelve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditableBookshelve.Dock = DockStyle.Fill;
            dataGridViewEditableBookshelve.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewEditableBookshelve.Location = new Point(3, 124);
            dataGridViewEditableBookshelve.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEditableBookshelve.Name = "dataGridViewEditableBookshelve";
            dataGridViewEditableBookshelve.RowHeadersVisible = false;
            dataGridViewEditableBookshelve.RowHeadersWidth = 62;
            dataGridViewEditableBookshelve.RowTemplate.Height = 25;
            dataGridViewEditableBookshelve.Size = new Size(894, 472);
            dataGridViewEditableBookshelve.TabIndex = 1;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label adminName2;
        private DataGridView dataGridViewEditableBookshelve;
        private DataGridView dataGridViewEditableListUsers;
        private Button buttonUserSave;
        private Button buttonBookSave;
    }
}