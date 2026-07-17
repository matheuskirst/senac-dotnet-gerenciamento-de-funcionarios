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
            LabelAdminLoginTitulo = new Label();
            PanelCredenciaisAdmin = new Panel();
            LabelAdminUsuario = new Label();
            TxtBoxAdminUsuario = new TextBox();
            LabelAdminSenha = new Label();
            TxtBoxAdminSenha = new TextBox();
            BtnAdminLogin = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            PanelCredenciaisAdmin.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // LabelAdminLoginTitulo
            // 
            LabelAdminLoginTitulo.Dock = DockStyle.Top;
            LabelAdminLoginTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAdminLoginTitulo.Location = new Point(0, 0);
            LabelAdminLoginTitulo.Name = "LabelAdminLoginTitulo";
            LabelAdminLoginTitulo.Size = new Size(207, 21);
            LabelAdminLoginTitulo.TabIndex = 1;
            LabelAdminLoginTitulo.Text = "Login Administrador";
            LabelAdminLoginTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelCredenciaisAdmin
            // 
            PanelCredenciaisAdmin.Anchor = AnchorStyles.None;
            PanelCredenciaisAdmin.BorderStyle = BorderStyle.FixedSingle;
            PanelCredenciaisAdmin.Controls.Add(LabelAdminLoginTitulo);
            PanelCredenciaisAdmin.Controls.Add(LabelAdminUsuario);
            PanelCredenciaisAdmin.Controls.Add(TxtBoxAdminUsuario);
            PanelCredenciaisAdmin.Controls.Add(LabelAdminSenha);
            PanelCredenciaisAdmin.Controls.Add(TxtBoxAdminSenha);
            PanelCredenciaisAdmin.Controls.Add(BtnAdminLogin);
            PanelCredenciaisAdmin.Location = new Point(74, 159);
            PanelCredenciaisAdmin.Margin = new Padding(3, 2, 3, 2);
            PanelCredenciaisAdmin.MaximumSize = new Size(345, 175);
            PanelCredenciaisAdmin.Name = "PanelCredenciaisAdmin";
            PanelCredenciaisAdmin.Size = new Size(209, 131);
            PanelCredenciaisAdmin.TabIndex = 0;
            // 
            // LabelAdminUsuario
            // 
            LabelAdminUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelAdminUsuario.AutoSize = true;
            LabelAdminUsuario.Font = new Font("Segoe UI", 10.2F);
            LabelAdminUsuario.Location = new Point(3, 45);
            LabelAdminUsuario.Name = "LabelAdminUsuario";
            LabelAdminUsuario.Size = new Size(59, 19);
            LabelAdminUsuario.TabIndex = 0;
            LabelAdminUsuario.Text = "Usuário:";
            // 
            // TxtBoxAdminUsuario
            // 
            TxtBoxAdminUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBoxAdminUsuario.Font = new Font("Segoe UI", 10.2F);
            TxtBoxAdminUsuario.Location = new Point(62, 43);
            TxtBoxAdminUsuario.Margin = new Padding(3, 2, 3, 2);
            TxtBoxAdminUsuario.Name = "TxtBoxAdminUsuario";
            TxtBoxAdminUsuario.Size = new Size(138, 26);
            TxtBoxAdminUsuario.TabIndex = 1;
            // 
            // LabelAdminSenha
            // 
            LabelAdminSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelAdminSenha.AutoSize = true;
            LabelAdminSenha.Font = new Font("Segoe UI", 10.2F);
            LabelAdminSenha.Location = new Point(4, 74);
            LabelAdminSenha.Name = "LabelAdminSenha";
            LabelAdminSenha.Size = new Size(49, 19);
            LabelAdminSenha.TabIndex = 3;
            LabelAdminSenha.Text = "Senha:";
            // 
            // TxtBoxAdminSenha
            // 
            TxtBoxAdminSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBoxAdminSenha.Font = new Font("Segoe UI", 10.2F);
            TxtBoxAdminSenha.Location = new Point(62, 72);
            TxtBoxAdminSenha.Margin = new Padding(3, 2, 3, 2);
            TxtBoxAdminSenha.Name = "TxtBoxAdminSenha";
            TxtBoxAdminSenha.Size = new Size(138, 26);
            TxtBoxAdminSenha.TabIndex = 2;
            TxtBoxAdminSenha.UseSystemPasswordChar = true;
            // 
            // BtnAdminLogin
            // 
            BtnAdminLogin.Dock = DockStyle.Bottom;
            BtnAdminLogin.Font = new Font("Segoe UI", 10.2F);
            BtnAdminLogin.Location = new Point(0, 102);
            BtnAdminLogin.Margin = new Padding(3, 2, 3, 2);
            BtnAdminLogin.Name = "BtnAdminLogin";
            BtnAdminLogin.Size = new Size(207, 27);
            BtnAdminLogin.TabIndex = 4;
            BtnAdminLogin.Text = "Entrar";
            BtnAdminLogin.UseVisualStyleBackColor = true;
            BtnAdminLogin.Click += BtnAdminLogin_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.Controls.Add(PanelCredenciaisAdmin, 1, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.Size = new Size(359, 451);
            tableLayoutPanelMain.TabIndex = 5;
            // 
            // FormLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 451);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(375, 490);
            MinimumSize = new Size(375, 490);
            Name = "FormLoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Administrador";
            PanelCredenciaisAdmin.ResumeLayout(false);
            PanelCredenciaisAdmin.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LabelAdminLoginTitulo;
        private Panel PanelCredenciaisAdmin;
        private Button BtnAdminLogin;
        private Label LabelAdminSenha;
        private TextBox TxtBoxAdminSenha;
        private TextBox TxtBoxAdminUsuario;
        private Label LabelAdminUsuario;
        private TableLayoutPanel tableLayoutPanelMain;
    }
}