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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameAdmin = new System.Windows.Forms.Label();
            this.dataGridViewEditableListUsers = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminName2 = new System.Windows.Forms.Label();
            this.dataGridViewEditableBookshelve = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUserSave = new System.Windows.Forms.Button();
            this.buttonBookSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditableListUsers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditableBookshelve)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEditableListUsers, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 702);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUserSave);
            this.panel1.Controls.Add(this.nameAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 140);
            this.panel1.TabIndex = 0;
            // 
            // nameAdmin
            // 
            this.nameAdmin.AutoSize = true;
            this.nameAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameAdmin.Location = new System.Drawing.Point(34, 35);
            this.nameAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameAdmin.Name = "nameAdmin";
            this.nameAdmin.Size = new System.Drawing.Size(65, 48);
            this.nameAdmin.TabIndex = 0;
            this.nameAdmin.Text = "***";
            // 
            // dataGridViewEditableListUsers
            // 
            this.dataGridViewEditableListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditableListUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEditableListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditableListUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DataBirth});
            this.dataGridViewEditableListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEditableListUsers.Location = new System.Drawing.Point(3, 153);
            this.dataGridViewEditableListUsers.Name = "dataGridViewEditableListUsers";
            this.dataGridViewEditableListUsers.RowHeadersVisible = false;
            this.dataGridViewEditableListUsers.RowHeadersWidth = 62;
            this.dataGridViewEditableListUsers.RowTemplate.Height = 33;
            this.dataGridViewEditableListUsers.Size = new System.Drawing.Size(1121, 546);
            this.dataGridViewEditableListUsers.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя пользователя";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            // 
            // DataBirth
            // 
            this.DataBirth.HeaderText = "День рождения";
            this.DataBirth.MinimumWidth = 8;
            this.DataBirth.Name = "DataBirth";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 750);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1135, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1135, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Книги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewEditableBookshelve, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1127, 702);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonBookSave);
            this.panel2.Controls.Add(this.adminName2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 140);
            this.panel2.TabIndex = 0;
            // 
            // adminName2
            // 
            this.adminName2.AutoSize = true;
            this.adminName2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminName2.Location = new System.Drawing.Point(30, 37);
            this.adminName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminName2.Name = "adminName2";
            this.adminName2.Size = new System.Drawing.Size(324, 48);
            this.adminName2.TabIndex = 0;
            this.adminName2.Text = "Имя пользователя";
            // 
            // dataGridViewEditableBookshelve
            // 
            this.dataGridViewEditableBookshelve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditableBookshelve.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewEditableBookshelve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditableBookshelve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewEditableBookshelve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEditableBookshelve.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewEditableBookshelve.Location = new System.Drawing.Point(4, 155);
            this.dataGridViewEditableBookshelve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewEditableBookshelve.Name = "dataGridViewEditableBookshelve";
            this.dataGridViewEditableBookshelve.RowHeadersVisible = false;
            this.dataGridViewEditableBookshelve.RowHeadersWidth = 62;
            this.dataGridViewEditableBookshelve.RowTemplate.Height = 25;
            this.dataGridViewEditableBookshelve.Size = new System.Drawing.Size(1119, 590);
            this.dataGridViewEditableBookshelve.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Год публикации";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // buttonUserSave
            // 
            this.buttonUserSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUserSave.Location = new System.Drawing.Point(990, 13);
            this.buttonUserSave.Name = "buttonUserSave";
            this.buttonUserSave.Size = new System.Drawing.Size(117, 88);
            this.buttonUserSave.TabIndex = 1;
            this.buttonUserSave.Text = "Сохранить изменения";
            this.buttonUserSave.UseVisualStyleBackColor = true;
            this.buttonUserSave.Click += new System.EventHandler(this.buttonUserSave_Click);
            // 
            // buttonBookSave
            // 
            this.buttonBookSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookSave.Location = new System.Drawing.Point(987, 24);
            this.buttonBookSave.Name = "buttonBookSave";
            this.buttonBookSave.Size = new System.Drawing.Size(117, 88);
            this.buttonBookSave.TabIndex = 2;
            this.buttonBookSave.Text = "Сохранить изменения";
            this.buttonBookSave.UseVisualStyleBackColor = true;
            this.buttonBookSave.Click += new System.EventHandler(this.buttonBookSave_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibrarianForm";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditableListUsers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditableBookshelve)).EndInit();
            this.ResumeLayout(false);

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
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn DataBirth;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button buttonUserSave;
        private Button buttonBookSave;
    }
}