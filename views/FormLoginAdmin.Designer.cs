namespace GerenciamentoDeFuncionarios.views
{
    partial class FormLoginAdmin
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
            label3 = new Label();
            panel1 = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUser = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 158);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 1;
            label3.Text = "Login Administrador";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(txtBoxUser);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(84, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 153);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Font = new Font("Segoe UI", 10.2F);
            btnLogin.Location = new Point(71, 119);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.MouseClick += btnLogin_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(4, 55);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPassword.Font = new Font("Segoe UI", 10.2F);
            txtBoxPassword.Location = new Point(71, 52);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(156, 30);
            txtBoxPassword.TabIndex = 2;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxUser.Font = new Font("Segoe UI", 10.2F);
            txtBoxUser.Location = new Point(71, 19);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(156, 30);
            txtBoxUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(407, 533);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // FormLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 533);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(425, 580);
            Name = "FormLoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUser;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}