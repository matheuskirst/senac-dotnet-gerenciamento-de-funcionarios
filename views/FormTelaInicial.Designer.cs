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
            btnAdmin = new Button();
            btnFunc = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Fill;
            btnAdmin.Font = new Font("Segoe UI", 10.8F);
            btnAdmin.Location = new Point(104, 216);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(197, 47);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Sou Administrador";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.MouseClick += btnAdmin_MouseClick;
            // 
            // btnFunc
            // 
            btnFunc.Dock = DockStyle.Fill;
            btnFunc.Font = new Font("Segoe UI", 10.8F);
            btnFunc.Location = new Point(104, 269);
            btnFunc.Name = "btnFunc";
            btnFunc.Size = new Size(197, 47);
            btnFunc.TabIndex = 1;
            btnFunc.Text = "Sou Funcionário";
            btnFunc.UseVisualStyleBackColor = true;
            btnFunc.MouseClick += btnFunc_MouseClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnAdmin, 1, 1);
            tableLayoutPanel1.Controls.Add(btnFunc, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(407, 533);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // FormTelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 533);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(425, 580);
            Name = "FormTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnFunc;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
