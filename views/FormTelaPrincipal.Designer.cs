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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mainTable = new TableLayoutPanel();
            PanelPesquisar = new TableLayoutPanel();
            LabelPesquisar = new Label();
            TextBoxBuscarFuncionario = new TextBox();
            PanelControles = new Panel();
            BtnRemoverFuncionario = new Button();
            BtnEditarFuncionario = new Button();
            BtnNovoFuncionario = new Button();
            DgvFuncionarios = new DataGridView();
            BtnAtualizarDgv = new Button();
            mainTable.SuspendLayout();
            PanelPesquisar.SuspendLayout();
            PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // mainTable
            // 
            mainTable.ColumnCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTable.Controls.Add(PanelPesquisar, 0, 0);
            mainTable.Controls.Add(PanelControles, 0, 2);
            mainTable.Controls.Add(DgvFuncionarios, 0, 1);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 0);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 3;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            mainTable.Size = new Size(742, 595);
            mainTable.TabIndex = 0;
            // 
            // PanelPesquisar
            // 
            PanelPesquisar.ColumnCount = 4;
            PanelPesquisar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            PanelPesquisar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 410F));
            PanelPesquisar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            PanelPesquisar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelPesquisar.Controls.Add(LabelPesquisar, 0, 1);
            PanelPesquisar.Controls.Add(TextBoxBuscarFuncionario, 1, 1);
            PanelPesquisar.Controls.Add(BtnAtualizarDgv, 2, 1);
            PanelPesquisar.Dock = DockStyle.Fill;
            PanelPesquisar.Location = new Point(3, 3);
            PanelPesquisar.Name = "PanelPesquisar";
            PanelPesquisar.RowCount = 3;
            PanelPesquisar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelPesquisar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            PanelPesquisar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelPesquisar.Size = new Size(736, 54);
            PanelPesquisar.TabIndex = 4;
            // 
            // LabelPesquisar
            // 
            LabelPesquisar.AutoSize = true;
            LabelPesquisar.Dock = DockStyle.Fill;
            LabelPesquisar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPesquisar.Location = new Point(3, 9);
            LabelPesquisar.Name = "LabelPesquisar";
            LabelPesquisar.Size = new Size(94, 35);
            LabelPesquisar.TabIndex = 0;
            LabelPesquisar.Text = "Pesquisar:";
            LabelPesquisar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxBuscarFuncionario
            // 
            TextBoxBuscarFuncionario.BackColor = SystemColors.Window;
            TextBoxBuscarFuncionario.BorderStyle = BorderStyle.FixedSingle;
            TextBoxBuscarFuncionario.Location = new Point(103, 12);
            TextBoxBuscarFuncionario.Name = "TextBoxBuscarFuncionario";
            TextBoxBuscarFuncionario.Size = new Size(400, 27);
            TextBoxBuscarFuncionario.TabIndex = 1;
            TextBoxBuscarFuncionario.TextChanged += TextBoxBuscarFuncionario_TextChanged;
            // 
            // PanelControles
            // 
            PanelControles.BackColor = SystemColors.ActiveCaption;
            PanelControles.Controls.Add(BtnRemoverFuncionario);
            PanelControles.Controls.Add(BtnEditarFuncionario);
            PanelControles.Controls.Add(BtnNovoFuncionario);
            PanelControles.Dock = DockStyle.Fill;
            PanelControles.Location = new Point(3, 528);
            PanelControles.Name = "PanelControles";
            PanelControles.Size = new Size(736, 64);
            PanelControles.TabIndex = 3;
            // 
            // BtnRemoverFuncionario
            // 
            BtnRemoverFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRemoverFuncionario.BackColor = Color.White;
            BtnRemoverFuncionario.Location = new Point(483, 5);
            BtnRemoverFuncionario.MaximumSize = new Size(200, 60);
            BtnRemoverFuncionario.MinimumSize = new Size(183, 53);
            BtnRemoverFuncionario.Name = "BtnRemoverFuncionario";
            BtnRemoverFuncionario.Size = new Size(183, 55);
            BtnRemoverFuncionario.TabIndex = 2;
            BtnRemoverFuncionario.Text = "Excluir";
            BtnRemoverFuncionario.UseVisualStyleBackColor = false;
            BtnRemoverFuncionario.Click += BtnRemoverFuncionario_Click;
            // 
            // BtnEditarFuncionario
            // 
            BtnEditarFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEditarFuncionario.BackColor = Color.White;
            BtnEditarFuncionario.Location = new Point(289, 5);
            BtnEditarFuncionario.MaximumSize = new Size(200, 60);
            BtnEditarFuncionario.MinimumSize = new Size(183, 53);
            BtnEditarFuncionario.Name = "BtnEditarFuncionario";
            BtnEditarFuncionario.Size = new Size(183, 55);
            BtnEditarFuncionario.TabIndex = 1;
            BtnEditarFuncionario.Text = "Editar";
            BtnEditarFuncionario.UseVisualStyleBackColor = false;
            BtnEditarFuncionario.Click += BtnEditarFuncionario_Click;
            // 
            // BtnNovoFuncionario
            // 
            BtnNovoFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNovoFuncionario.BackColor = Color.White;
            BtnNovoFuncionario.Location = new Point(3, 5);
            BtnNovoFuncionario.MaximumSize = new Size(200, 60);
            BtnNovoFuncionario.MinimumSize = new Size(183, 53);
            BtnNovoFuncionario.Name = "BtnNovoFuncionario";
            BtnNovoFuncionario.Size = new Size(183, 55);
            BtnNovoFuncionario.TabIndex = 0;
            BtnNovoFuncionario.Text = "Novo";
            BtnNovoFuncionario.UseVisualStyleBackColor = false;
            BtnNovoFuncionario.Click += BtnNovoFuncionario_Click;
            // 
            // DgvFuncionarios
            // 
            DgvFuncionarios.AllowUserToOrderColumns = true;
            DgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            DgvFuncionarios.Dock = DockStyle.Fill;
            DgvFuncionarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvFuncionarios.Location = new Point(3, 63);
            DgvFuncionarios.Name = "DgvFuncionarios";
            DgvFuncionarios.RowHeadersWidth = 51;
            DgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvFuncionarios.Size = new Size(736, 459);
            DgvFuncionarios.TabIndex = 0;
            DgvFuncionarios.CellFormatting += DgvFuncionarios_CellFormatting;
            // 
            // BtnAtualizarDgv
            // 
            BtnAtualizarDgv.Dock = DockStyle.Fill;
            BtnAtualizarDgv.Location = new Point(513, 12);
            BtnAtualizarDgv.Name = "BtnAtualizarDgv";
            BtnAtualizarDgv.Size = new Size(94, 29);
            BtnAtualizarDgv.TabIndex = 2;
            BtnAtualizarDgv.Text = "Atualizar";
            BtnAtualizarDgv.UseVisualStyleBackColor = true;
            BtnAtualizarDgv.Click += BtnAtualizarDgv_Click;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 595);
            Controls.Add(mainTable);
            MinimumSize = new Size(760, 642);
            Name = "FormTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            Load += FormTelaPrincipal_Load;
            mainTable.ResumeLayout(false);
            PanelPesquisar.ResumeLayout(false);
            PanelPesquisar.PerformLayout();
            PanelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTable;
        private DataGridView DgvFuncionarios;
        private Panel PanelControles;
        private Button BtnRemoverFuncionario;
        private Button BtnEditarFuncionario;
        private Button BtnNovoFuncionario;
        private TableLayoutPanel PanelPesquisar;
        private Label LabelPesquisar;
        private TextBox TextBoxBuscarFuncionario;
        private Button BtnAtualizarDgv;
    }
}