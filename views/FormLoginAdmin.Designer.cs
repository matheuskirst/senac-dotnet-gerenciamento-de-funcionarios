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
            LabelUsuarioAdmin = new Label();
            TxtBoxUsuarioAdmin = new TextBox();
            LabelSenhaAdmin = new Label();
            TxtBoxSenhaAdmin = new TextBox();
            BtnAdminLogin = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            AdminVoltarButton = new Button();
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
            LabelAdminLoginTitulo.Size = new Size(236, 28);
            LabelAdminLoginTitulo.TabIndex = 1;
            LabelAdminLoginTitulo.Text = "Login Administrador";
            LabelAdminLoginTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelCredenciaisAdmin
            // 
            PanelCredenciaisAdmin.Anchor = AnchorStyles.None;
            PanelCredenciaisAdmin.BorderStyle = BorderStyle.FixedSingle;
            PanelCredenciaisAdmin.Controls.Add(LabelAdminLoginTitulo);
            PanelCredenciaisAdmin.Controls.Add(LabelUsuarioAdmin);
            PanelCredenciaisAdmin.Controls.Add(TxtBoxUsuarioAdmin);
            PanelCredenciaisAdmin.Controls.Add(LabelSenhaAdmin);
            PanelCredenciaisAdmin.Controls.Add(TxtBoxSenhaAdmin);
            PanelCredenciaisAdmin.Controls.Add(BtnAdminLogin);
            PanelCredenciaisAdmin.Location = new Point(84, 209);
            PanelCredenciaisAdmin.MaximumSize = new Size(394, 233);
            PanelCredenciaisAdmin.Name = "PanelCredenciaisAdmin";
            PanelCredenciaisAdmin.Size = new Size(238, 171);
            PanelCredenciaisAdmin.TabIndex = 0;
            // 
            // LabelUsuarioAdmin
            // 
            LabelUsuarioAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelUsuarioAdmin.AutoSize = true;
            LabelUsuarioAdmin.Font = new Font("Segoe UI", 10.2F);
            LabelUsuarioAdmin.Location = new Point(3, 60);
            LabelUsuarioAdmin.Name = "LabelUsuarioAdmin";
            LabelUsuarioAdmin.Size = new Size(72, 23);
            LabelUsuarioAdmin.TabIndex = 0;
            LabelUsuarioAdmin.Text = "Usuário:";
            // 
            // TxtBoxUsuarioAdmin
            // 
            TxtBoxUsuarioAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBoxUsuarioAdmin.Font = new Font("Segoe UI", 10.2F);
            TxtBoxUsuarioAdmin.Location = new Point(77, 57);
            TxtBoxUsuarioAdmin.Name = "TxtBoxUsuarioAdmin";
            TxtBoxUsuarioAdmin.Size = new Size(150, 30);
            TxtBoxUsuarioAdmin.TabIndex = 1;
            // 
            // LabelSenhaAdmin
            // 
            LabelSenhaAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelSenhaAdmin.AutoSize = true;
            LabelSenhaAdmin.Font = new Font("Segoe UI", 10.2F);
            LabelSenhaAdmin.Location = new Point(3, 99);
            LabelSenhaAdmin.Name = "LabelSenhaAdmin";
            LabelSenhaAdmin.Size = new Size(61, 23);
            LabelSenhaAdmin.TabIndex = 3;
            LabelSenhaAdmin.Text = "Senha:";
            // 
            // TxtBoxSenhaAdmin
            // 
            TxtBoxSenhaAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBoxSenhaAdmin.Font = new Font("Segoe UI", 10.2F);
            TxtBoxSenhaAdmin.Location = new Point(77, 97);
            TxtBoxSenhaAdmin.Name = "TxtBoxSenhaAdmin";
            TxtBoxSenhaAdmin.Size = new Size(150, 30);
            TxtBoxSenhaAdmin.TabIndex = 2;
            TxtBoxSenhaAdmin.UseSystemPasswordChar = true;
            // 
            // BtnAdminLogin
            // 
            BtnAdminLogin.Dock = DockStyle.Bottom;
            BtnAdminLogin.Font = new Font("Segoe UI", 10.2F);
            BtnAdminLogin.Location = new Point(0, 133);
            BtnAdminLogin.Name = "BtnAdminLogin";
            BtnAdminLogin.Size = new Size(236, 36);
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
            tableLayoutPanelMain.Controls.Add(AdminVoltarButton, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.Size = new Size(408, 591);
            tableLayoutPanelMain.TabIndex = 5;
            // 
            // AdminVoltarButton
            // 
            AdminVoltarButton.Location = new Point(3, 3);
            AdminVoltarButton.Name = "AdminVoltarButton";
            AdminVoltarButton.Size = new Size(75, 29);
            AdminVoltarButton.TabIndex = 1;
            AdminVoltarButton.Text = "Voltar";
            AdminVoltarButton.UseVisualStyleBackColor = true;
            AdminVoltarButton.Click += VoltarButton_Click;
            // 
            // FormLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 591);
            Controls.Add(tableLayoutPanelMain);
            MaximizeBox = false;
            MaximumSize = new Size(426, 638);
            MinimumSize = new Size(426, 638);
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
        private Label LabelSenhaAdmin;
        private TextBox TxtBoxSenhaAdmin;
        private TextBox TxtBoxUsuarioAdmin;
        private Label LabelUsuarioAdmin;
        private TableLayoutPanel tableLayoutPanelMain;
        private Button AdminVoltarButton;
    }
}