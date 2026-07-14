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
            labelTituloLoginAdmin = new Label();
            panelCredenciais = new Panel();
            labelUsuarioAdmin = new Label();
            txtBoxUserAdmin = new TextBox();
            labelSenhaAdmin = new Label();
            txtBoxPasswordAdmin = new TextBox();
            btnLoginAdmin = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelCredenciais.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // labelTituloLoginAdmin
            // 
            labelTituloLoginAdmin.Dock = DockStyle.Top;
            labelTituloLoginAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloLoginAdmin.Location = new Point(0, 0);
            labelTituloLoginAdmin.Name = "labelTituloLoginAdmin";
            labelTituloLoginAdmin.Size = new Size(343, 21);
            labelTituloLoginAdmin.TabIndex = 1;
            labelTituloLoginAdmin.Text = "Login Administrador";
            labelTituloLoginAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCredenciais
            // 
            panelCredenciais.Anchor = AnchorStyles.None;
            panelCredenciais.BorderStyle = BorderStyle.FixedSingle;
            panelCredenciais.Controls.Add(labelTituloLoginAdmin);
            panelCredenciais.Controls.Add(labelUsuarioAdmin);
            panelCredenciais.Controls.Add(txtBoxUserAdmin);
            panelCredenciais.Controls.Add(labelSenhaAdmin);
            panelCredenciais.Controls.Add(txtBoxPasswordAdmin);
            panelCredenciais.Controls.Add(btnLoginAdmin);
            panelCredenciais.Location = new Point(125, 218);
            panelCredenciais.Margin = new Padding(3, 2, 3, 2);
            panelCredenciais.MaximumSize = new Size(345, 175);
            panelCredenciais.Name = "panelCredenciais";
            panelCredenciais.Size = new Size(345, 175);
            panelCredenciais.TabIndex = 0;
            // 
            // labelUsuarioAdmin
            // 
            labelUsuarioAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUsuarioAdmin.AutoSize = true;
            labelUsuarioAdmin.Font = new Font("Segoe UI", 10.2F);
            labelUsuarioAdmin.Location = new Point(3, 49);
            labelUsuarioAdmin.Name = "labelUsuarioAdmin";
            labelUsuarioAdmin.Size = new Size(59, 19);
            labelUsuarioAdmin.TabIndex = 0;
            labelUsuarioAdmin.Text = "Usuário:";
            // 
            // txtBoxUserAdmin
            // 
            txtBoxUserAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxUserAdmin.Font = new Font("Segoe UI", 10.2F);
            txtBoxUserAdmin.Location = new Point(62, 47);
            txtBoxUserAdmin.Margin = new Padding(3, 2, 3, 2);
            txtBoxUserAdmin.Name = "txtBoxUserAdmin";
            txtBoxUserAdmin.Size = new Size(274, 26);
            txtBoxUserAdmin.TabIndex = 1;
            // 
            // labelSenhaAdmin
            // 
            labelSenhaAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSenhaAdmin.AutoSize = true;
            labelSenhaAdmin.Font = new Font("Segoe UI", 10.2F);
            labelSenhaAdmin.Location = new Point(4, 74);
            labelSenhaAdmin.Name = "labelSenhaAdmin";
            labelSenhaAdmin.Size = new Size(49, 19);
            labelSenhaAdmin.TabIndex = 3;
            labelSenhaAdmin.Text = "Senha:";
            // 
            // txtBoxPasswordAdmin
            // 
            txtBoxPasswordAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPasswordAdmin.Font = new Font("Segoe UI", 10.2F);
            txtBoxPasswordAdmin.Location = new Point(62, 72);
            txtBoxPasswordAdmin.Margin = new Padding(3, 2, 3, 2);
            txtBoxPasswordAdmin.Name = "txtBoxPasswordAdmin";
            txtBoxPasswordAdmin.Size = new Size(274, 26);
            txtBoxPasswordAdmin.TabIndex = 2;
            txtBoxPasswordAdmin.UseSystemPasswordChar = true;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Dock = DockStyle.Bottom;
            btnLoginAdmin.Font = new Font("Segoe UI", 10.2F);
            btnLoginAdmin.Location = new Point(0, 146);
            btnLoginAdmin.Margin = new Padding(3, 2, 3, 2);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(343, 27);
            btnLoginAdmin.TabIndex = 4;
            btnLoginAdmin.Text = "Entrar";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLogin_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.Controls.Add(panelCredenciais, 1, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.Size = new Size(595, 612);
            tableLayoutPanelMain.TabIndex = 5;
            // 
            // FormLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 612);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(375, 515);
            Name = "FormLoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Administrador";
            panelCredenciais.ResumeLayout(false);
            panelCredenciais.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTituloLoginAdmin;
        private Panel panelCredenciais;
        private Button btnLoginAdmin;
        private Label labelSenhaAdmin;
        private TextBox txtBoxPasswordAdmin;
        private TextBox txtBoxUserAdmin;
        private Label labelUsuarioAdmin;
        private TableLayoutPanel tableLayoutPanelMain;
    }
}