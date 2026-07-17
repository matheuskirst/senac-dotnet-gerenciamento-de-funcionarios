namespace GerenciamentoDeFuncionarios
{
    partial class FormTelaInicial
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
            BtnIdentificacaoAdmin = new Button();
            BtnIdentificacaoFunc = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIdentificacaoAdmin
            // 
            BtnIdentificacaoAdmin.Dock = DockStyle.Fill;
            BtnIdentificacaoAdmin.Font = new Font("Segoe UI", 10.8F);
            BtnIdentificacaoAdmin.Location = new Point(92, 164);
            BtnIdentificacaoAdmin.Margin = new Padding(3, 2, 3, 2);
            BtnIdentificacaoAdmin.Name = "BtnIdentificacaoAdmin";
            BtnIdentificacaoAdmin.Size = new Size(173, 36);
            BtnIdentificacaoAdmin.TabIndex = 0;
            BtnIdentificacaoAdmin.Text = "Sou Administrador";
            BtnIdentificacaoAdmin.UseVisualStyleBackColor = true;
            BtnIdentificacaoAdmin.MouseClick += BtnIdentificacaoAdmin_Click;
            // 
            // BtnIdentificacaoFunc
            // 
            BtnIdentificacaoFunc.Dock = DockStyle.Fill;
            BtnIdentificacaoFunc.Font = new Font("Segoe UI", 10.8F);
            BtnIdentificacaoFunc.Location = new Point(92, 204);
            BtnIdentificacaoFunc.Margin = new Padding(3, 2, 3, 2);
            BtnIdentificacaoFunc.Name = "BtnIdentificacaoFunc";
            BtnIdentificacaoFunc.Size = new Size(173, 36);
            BtnIdentificacaoFunc.TabIndex = 1;
            BtnIdentificacaoFunc.Text = "Sou Funcionário";
            BtnIdentificacaoFunc.UseVisualStyleBackColor = true;
            BtnIdentificacaoFunc.Click += BtnIdentificacaoFunc_Click;
            BtnIdentificacaoFunc.MouseClick += BtnIdentificacaoFunc_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(BtnIdentificacaoAdmin, 1, 1);
            tableLayoutPanel1.Controls.Add(BtnIdentificacaoFunc, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(358, 406);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // FormTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 406);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(374, 445);
            MinimumSize = new Size(374, 445);
            Name = "FormTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIdentificacaoAdmin;
        private Button BtnIdentificacaoFunc;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
