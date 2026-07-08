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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnNewEmployee = new Button();
            btnEditEmployee = new Button();
            btnDeleteEmployee = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.625F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.Size = new Size(770, 586);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(764, 501);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnNewEmployee, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEditEmployee, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDeleteEmployee, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 510);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(764, 73);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.BackColor = Color.Gainsboro;
            btnNewEmployee.Dock = DockStyle.Fill;
            btnNewEmployee.Location = new Point(3, 3);
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Size = new Size(185, 67);
            btnNewEmployee.TabIndex = 0;
            btnNewEmployee.Text = "Novo";
            btnNewEmployee.UseVisualStyleBackColor = false;
            btnNewEmployee.Click += btnNewEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.Gainsboro;
            btnEditEmployee.Dock = DockStyle.Fill;
            btnEditEmployee.Location = new Point(385, 3);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(185, 67);
            btnEditEmployee.TabIndex = 1;
            btnEditEmployee.Text = "Editar";
            btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.Gainsboro;
            btnDeleteEmployee.Dock = DockStyle.Fill;
            btnDeleteEmployee.Location = new Point(576, 3);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(185, 67);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Excluir";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 586);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(540, 500);
            Name = "FormTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnNewEmployee;
        private Button btnEditEmployee;
        private Button btnDeleteEmployee;
    }
}