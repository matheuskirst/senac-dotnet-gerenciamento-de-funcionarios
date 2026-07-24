namespace GerenciamentoDeFuncionarios.views
{
    partial class FormLoginFuncionario
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
            tableLayoutPanelMain = new TableLayoutPanel();
            PanelCredenciaisFunc = new Panel();
            LabelSenhaFunc = new Label();
            TxtBoxSenhaFunc = new TextBox();
            LabelFuncLoginTitulo = new Label();
            LabelMatriculaFunc = new Label();
            TxtBoxMatriculaFunc = new TextBox();
            BtnFuncLogin = new Button();
            FuncVoltarButton = new Button();
            tableLayoutPanelMain.SuspendLayout();
            PanelCredenciaisFunc.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.Controls.Add(PanelCredenciaisFunc, 1, 1);
            tableLayoutPanelMain.Controls.Add(FuncVoltarButton, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.Size = new Size(408, 591);
            tableLayoutPanelMain.TabIndex = 6;
            // 
            // PanelCredenciaisFunc
            // 
            PanelCredenciaisFunc.Anchor = AnchorStyles.None;
            PanelCredenciaisFunc.BorderStyle = BorderStyle.FixedSingle;
            PanelCredenciaisFunc.Controls.Add(LabelSenhaFunc);
            PanelCredenciaisFunc.Controls.Add(TxtBoxSenhaFunc);
            PanelCredenciaisFunc.Controls.Add(LabelFuncLoginTitulo);
            PanelCredenciaisFunc.Controls.Add(LabelMatriculaFunc);
            PanelCredenciaisFunc.Controls.Add(TxtBoxMatriculaFunc);
            PanelCredenciaisFunc.Controls.Add(BtnFuncLogin);
            PanelCredenciaisFunc.Location = new Point(84, 209);
            PanelCredenciaisFunc.MaximumSize = new Size(394, 233);
            PanelCredenciaisFunc.Name = "PanelCredenciaisFunc";
            PanelCredenciaisFunc.Size = new Size(238, 171);
            PanelCredenciaisFunc.TabIndex = 0;
            // 
            // LabelSenhaFunc
            // 
            LabelSenhaFunc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelSenhaFunc.AutoSize = true;
            LabelSenhaFunc.Font = new Font("Segoe UI", 10.2F);
            LabelSenhaFunc.Location = new Point(3, 99);
            LabelSenhaFunc.Name = "LabelSenhaFunc";
            LabelSenhaFunc.Size = new Size(61, 23);
            LabelSenhaFunc.TabIndex = 6;
            LabelSenhaFunc.Text = "Senha:";
            // 
            // TxtBoxSenhaFunc
            // 
            TxtBoxSenhaFunc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBoxSenhaFunc.Font = new Font("Segoe UI", 10.2F);
            TxtBoxSenhaFunc.Location = new Point(77, 96);
            TxtBoxSenhaFunc.Name = "TxtBoxSenhaFunc";
            TxtBoxSenhaFunc.Size = new Size(150, 30);
            TxtBoxSenhaFunc.TabIndex = 5;
            TxtBoxSenhaFunc.UseSystemPasswordChar = true;
            // 
            // LabelFuncLoginTitulo
            // 
            LabelFuncLoginTitulo.Dock = DockStyle.Top;
            LabelFuncLoginTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFuncLoginTitulo.Location = new Point(0, 0);
            LabelFuncLoginTitulo.Name = "LabelFuncLoginTitulo";
            LabelFuncLoginTitulo.Size = new Size(236, 28);
            LabelFuncLoginTitulo.TabIndex = 1;
            LabelFuncLoginTitulo.Text = "Login Funcionário";
            LabelFuncLoginTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelMatriculaFunc
            // 
            LabelMatriculaFunc.AutoSize = true;
            LabelMatriculaFunc.Font = new Font("Segoe UI", 10.2F);
            LabelMatriculaFunc.Location = new Point(3, 60);
            LabelMatriculaFunc.Name = "LabelMatriculaFunc";
            LabelMatriculaFunc.Size = new Size(85, 23);
            LabelMatriculaFunc.TabIndex = 0;
            LabelMatriculaFunc.Text = "Mátricula:";
            // 
            // TxtBoxMatriculaFunc
            // 
            TxtBoxMatriculaFunc.Font = new Font("Segoe UI", 10.2F);
            TxtBoxMatriculaFunc.Location = new Point(94, 57);
            TxtBoxMatriculaFunc.Name = "TxtBoxMatriculaFunc";
            TxtBoxMatriculaFunc.Size = new Size(133, 30);
            TxtBoxMatriculaFunc.TabIndex = 1;
            // 
            // BtnFuncLogin
            // 
            BtnFuncLogin.Dock = DockStyle.Bottom;
            BtnFuncLogin.Font = new Font("Segoe UI", 10.2F);
            BtnFuncLogin.Location = new Point(0, 133);
            BtnFuncLogin.Name = "BtnFuncLogin";
            BtnFuncLogin.Size = new Size(236, 36);
            BtnFuncLogin.TabIndex = 4;
            BtnFuncLogin.Text = "Entrar";
            BtnFuncLogin.UseVisualStyleBackColor = true;
            BtnFuncLogin.Click += BtnFuncLogin_Click;
            // 
            // FuncVoltarButton
            // 
            FuncVoltarButton.Location = new Point(3, 3);
            FuncVoltarButton.Name = "FuncVoltarButton";
            FuncVoltarButton.Size = new Size(75, 29);
            FuncVoltarButton.TabIndex = 1;
            FuncVoltarButton.Text = "Voltar";
            FuncVoltarButton.UseVisualStyleBackColor = true;
            FuncVoltarButton.Click += VoltarButtonFunc_Click;
            // 
            // FormLoginFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 591);
            Controls.Add(tableLayoutPanelMain);
            MaximumSize = new Size(426, 638);
            MinimumSize = new Size(426, 638);
            Name = "FormLoginFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Funcionário";
            tableLayoutPanelMain.ResumeLayout(false);
            PanelCredenciaisFunc.ResumeLayout(false);
            PanelCredenciaisFunc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private Panel PanelCredenciaisFunc;
        private Label LabelFuncLoginTitulo;
        private Label LabelMatriculaFunc;
        private TextBox TxtBoxMatriculaFunc;
        private Button BtnFuncLogin;
        private Label LabelSenhaFunc;
        private TextBox TxtBoxSenhaFunc;
        private Button FuncVoltarButton;
    }
}