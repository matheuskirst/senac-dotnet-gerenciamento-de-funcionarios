namespace GerenciamentoDeFuncionarios.views
{
    partial class FormTelaPrincipal
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
            mainTable = new TableLayoutPanel();
            dgvFuncionarios = new DataGridView();
            panel1 = new Panel();
            btnDeleteEmployee = new Button();
            btnEditEmployee = new Button();
            btnNewEmployee = new Button();
            mainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTable
            // 
            mainTable.ColumnCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTable.Controls.Add(dgvFuncionarios, 0, 0);
            mainTable.Controls.Add(panel1, 0, 1);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 0);
            mainTable.Margin = new Padding(3, 2, 3, 2);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 2;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            mainTable.Size = new Size(695, 420);
            mainTable.TabIndex = 0;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Dock = DockStyle.Fill;
            dgvFuncionarios.Location = new Point(3, 2);
            dgvFuncionarios.Margin = new Padding(3, 2, 3, 2);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersWidth = 51;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(689, 364);
            dgvFuncionarios.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnDeleteEmployee);
            panel1.Controls.Add(btnEditEmployee);
            panel1.Controls.Add(btnNewEmployee);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 370);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 48);
            panel1.TabIndex = 3;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteEmployee.BackColor = Color.White;
            btnDeleteEmployee.Location = new Point(526, 4);
            btnDeleteEmployee.Margin = new Padding(3, 2, 3, 2);
            btnDeleteEmployee.MaximumSize = new Size(175, 45);
            btnDeleteEmployee.MinimumSize = new Size(160, 40);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(160, 40);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Excluir";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditEmployee.BackColor = Color.White;
            btnEditEmployee.Location = new Point(357, 4);
            btnEditEmployee.Margin = new Padding(3, 2, 3, 2);
            btnEditEmployee.MaximumSize = new Size(175, 45);
            btnEditEmployee.MinimumSize = new Size(160, 40);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(160, 40);
            btnEditEmployee.TabIndex = 1;
            btnEditEmployee.Text = "Editar";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewEmployee.BackColor = Color.White;
            btnNewEmployee.Location = new Point(3, 4);
            btnNewEmployee.Margin = new Padding(3, 2, 3, 2);
            btnNewEmployee.MaximumSize = new Size(175, 45);
            btnNewEmployee.MinimumSize = new Size(160, 40);
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Size = new Size(160, 40);
            btnNewEmployee.TabIndex = 0;
            btnNewEmployee.Text = "Novo";
            btnNewEmployee.UseVisualStyleBackColor = false;
            btnNewEmployee.Click += btnNewEmployee_Click;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 420);
            Controls.Add(mainTable);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(553, 385);
            Name = "FormTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            mainTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTable;
        private DataGridView dgvFuncionarios;
        private Panel panel1;
        private Button btnDeleteEmployee;
        private Button btnEditEmployee;
        private Button btnNewEmployee;
    }
}