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
            LabelFuncLoginTitulo = new Label();
            LabelFuncMatricula = new Label();
            TxtBoxFuncMatricula = new TextBox();
            BtnFuncLogin = new Button();
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
            PanelCredenciaisFunc.Controls.Add(LabelFuncLoginTitulo);
            PanelCredenciaisFunc.Controls.Add(LabelFuncMatricula);
            PanelCredenciaisFunc.Controls.Add(TxtBoxFuncMatricula);
            PanelCredenciaisFunc.Controls.Add(BtnFuncLogin);
            PanelCredenciaisFunc.Location = new Point(84, 209);
            PanelCredenciaisFunc.MaximumSize = new Size(394, 233);
            PanelCredenciaisFunc.Name = "PanelCredenciaisFunc";
            PanelCredenciaisFunc.Size = new Size(238, 171);
            PanelCredenciaisFunc.TabIndex = 0;
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
            // LabelFuncMatricula
            // 
            LabelFuncMatricula.AutoSize = true;
            LabelFuncMatricula.Font = new Font("Segoe UI", 10.2F);
            LabelFuncMatricula.Location = new Point(3, 72);
            LabelFuncMatricula.Name = "LabelFuncMatricula";
            LabelFuncMatricula.Size = new Size(85, 23);
            LabelFuncMatricula.TabIndex = 0;
            LabelFuncMatricula.Text = "Mátricula:";
            // 
            // TxtBoxFuncMatricula
            // 
            TxtBoxFuncMatricula.Font = new Font("Segoe UI", 10.2F);
            TxtBoxFuncMatricula.Location = new Point(94, 69);
            TxtBoxFuncMatricula.Name = "TxtBoxFuncMatricula";
            TxtBoxFuncMatricula.Size = new Size(133, 30);
            TxtBoxFuncMatricula.TabIndex = 1;
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
        private Label LabelFuncMatricula;
        private TextBox TxtBoxFuncMatricula;
        private Button BtnFuncLogin;
    }
}