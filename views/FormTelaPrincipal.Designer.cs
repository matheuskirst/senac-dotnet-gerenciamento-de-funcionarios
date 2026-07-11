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
            mainTable.Name = "mainTable";
            mainTable.RowCount = 2;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            mainTable.Size = new Size(612, 453);
            mainTable.TabIndex = 0;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Dock = DockStyle.Fill;
            dgvFuncionarios.Location = new Point(3, 3);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersWidth = 51;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(606, 377);
            dgvFuncionarios.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteEmployee);
            panel1.Controls.Add(btnEditEmployee);
            panel1.Controls.Add(btnNewEmployee);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 64);
            panel1.TabIndex = 3;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteEmployee.BackColor = Color.Gainsboro;
            btnDeleteEmployee.Location = new Point(418, 2);
            btnDeleteEmployee.MaximumSize = new Size(200, 60);
            btnDeleteEmployee.MinimumSize = new Size(185, 55);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(185, 60);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Excluir";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditEmployee.BackColor = Color.Gainsboro;
            btnEditEmployee.Location = new Point(227, 5);
            btnEditEmployee.MaximumSize = new Size(200, 60);
            btnEditEmployee.MinimumSize = new Size(185, 55);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(185, 55);
            btnEditEmployee.TabIndex = 1;
            btnEditEmployee.Text = "Editar";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewEmployee.BackColor = Color.Gainsboro;
            btnNewEmployee.Location = new Point(3, 5);
            btnNewEmployee.MaximumSize = new Size(200, 60);
            btnNewEmployee.MinimumSize = new Size(185, 55);
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Size = new Size(185, 55);
            btnNewEmployee.TabIndex = 0;
            btnNewEmployee.Text = "Novo";
            btnNewEmployee.UseVisualStyleBackColor = false;
            btnNewEmployee.Click += btnNewEmployee_Click;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 453);
            Controls.Add(mainTable);
            MinimumSize = new Size(630, 500);
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