namespace LibrarryTP
{
    partial class AuthRegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLoginAsUser = new Button();
            buttonLoginAsLibrarian = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLoginAsUser
            // 
            buttonLoginAsUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoginAsUser.Location = new Point(83, 42);
            buttonLoginAsUser.Name = "buttonLoginAsUser";
            buttonLoginAsUser.Size = new Size(156, 48);
            buttonLoginAsUser.TabIndex = 0;
            buttonLoginAsUser.Text = "Пользователь";
            buttonLoginAsUser.UseVisualStyleBackColor = true;
            buttonLoginAsUser.Click += buttonLoginAsUser_Click;
            // 
            // buttonLoginAsLibrarian
            // 
            buttonLoginAsLibrarian.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoginAsLibrarian.Location = new Point(296, 42);
            buttonLoginAsLibrarian.Name = "buttonLoginAsLibrarian";
            buttonLoginAsLibrarian.Size = new Size(156, 48);
            buttonLoginAsLibrarian.TabIndex = 1;
            buttonLoginAsLibrarian.Text = "Библиотекарь";
            buttonLoginAsLibrarian.UseVisualStyleBackColor = true;
            buttonLoginAsLibrarian.Click += buttonLoginAsLibrarian_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(174, 8);
            label1.Name = "label1";
            label1.Size = new Size(191, 40);
            label1.TabIndex = 2;
            label1.Text = "Авторизация";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLoginAsLibrarian);
            panel1.Controls.Add(buttonLoginAsUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 160);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 80);
            panel2.TabIndex = 4;
            // 
            // AuthRegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 246);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AuthRegForm";
            Text = "AuthRegForm";
            Load += AuthRegForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoginAsUser;
        private Button buttonLoginAsLibrarian;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}