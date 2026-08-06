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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            mainTable = new TableLayoutPanel();
            PanelBuscar = new TableLayoutPanel();
            TelaInicialButton = new Button();
            BtnAtualizarDgv = new Button();
            BtnRealizarPesquisa = new Button();
            PanelBarraDeBuscar = new TableLayoutPanel();
            BtnLimparBusca = new Button();
            TextBoxBuscarFuncionario = new TextBox();
            label1 = new Label();
            ContratoComboBox = new ComboBox();
            LabelContrato = new Label();
            PanelControles = new Panel();
            BtnRemoverFuncionario = new Button();
            BtnEditarFuncionario = new Button();
            BtnNovoFuncionario = new Button();
            DgvFuncionarios = new DataGridView();
            LabelNenhumFuncErro = new Label();
            mainTable.SuspendLayout();
            PanelBuscar.SuspendLayout();
            PanelBarraDeBuscar.SuspendLayout();
            PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // mainTable
            // 
            mainTable.ColumnCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTable.Controls.Add(PanelBuscar, 0, 0);
            mainTable.Controls.Add(PanelControles, 0, 3);
            mainTable.Controls.Add(DgvFuncionarios, 0, 2);
            mainTable.Controls.Add(LabelNenhumFuncErro, 0, 1);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 0);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 4;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            mainTable.Size = new Size(1062, 673);
            mainTable.TabIndex = 0;
            // 
            // PanelBuscar
            // 
            PanelBuscar.ColumnCount = 9;
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 410F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            PanelBuscar.Controls.Add(TelaInicialButton, 0, 1);
            PanelBuscar.Controls.Add(BtnAtualizarDgv, 6, 1);
            PanelBuscar.Controls.Add(BtnRealizarPesquisa, 5, 1);
            PanelBuscar.Controls.Add(PanelBarraDeBuscar, 2, 1);
            PanelBuscar.Controls.Add(label1, 1, 1);
            PanelBuscar.Controls.Add(ContratoComboBox, 4, 1);
            PanelBuscar.Controls.Add(LabelContrato, 3, 1);
            PanelBuscar.Dock = DockStyle.Fill;
            PanelBuscar.Location = new Point(0, 0);
            PanelBuscar.Margin = new Padding(0);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.RowCount = 3;
            PanelBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelBuscar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            PanelBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelBuscar.Size = new Size(1062, 60);
            PanelBuscar.TabIndex = 4;
            // 
            // TelaInicialButton
            // 
            TelaInicialButton.Location = new Point(3, 15);
            TelaInicialButton.Name = "TelaInicialButton";
            TelaInicialButton.Size = new Size(94, 29);
            TelaInicialButton.TabIndex = 0;
            TelaInicialButton.Text = "Tela Inicial";
            TelaInicialButton.UseVisualStyleBackColor = true;
            TelaInicialButton.Click += TelaInicialButton_Click;
            // 
            // BtnAtualizarDgv
            // 
            BtnAtualizarDgv.Dock = DockStyle.Fill;
            BtnAtualizarDgv.Location = new Point(845, 15);
            BtnAtualizarDgv.Name = "BtnAtualizarDgv";
            BtnAtualizarDgv.Size = new Size(95, 29);
            BtnAtualizarDgv.TabIndex = 4;
            BtnAtualizarDgv.Text = "Atualizar";
            BtnAtualizarDgv.UseVisualStyleBackColor = true;
            BtnAtualizarDgv.Click += BtnAtualizarDgv_Click;
            // 
            // BtnRealizarPesquisa
            // 
            BtnRealizarPesquisa.Dock = DockStyle.Fill;
            BtnRealizarPesquisa.Location = new Point(775, 15);
            BtnRealizarPesquisa.Name = "BtnRealizarPesquisa";
            BtnRealizarPesquisa.Size = new Size(64, 29);
            BtnRealizarPesquisa.TabIndex = 3;
            BtnRealizarPesquisa.Text = "Buscar";
            BtnRealizarPesquisa.UseVisualStyleBackColor = true;
            BtnRealizarPesquisa.Click += BtnRealizarPesquisa_Click;
            // 
            // PanelBarraDeBuscar
            // 
            PanelBarraDeBuscar.BackColor = SystemColors.Window;
            PanelBarraDeBuscar.BorderStyle = BorderStyle.FixedSingle;
            PanelBarraDeBuscar.ColumnCount = 2;
            PanelBarraDeBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelBarraDeBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            PanelBarraDeBuscar.Controls.Add(BtnLimparBusca, 1, 0);
            PanelBarraDeBuscar.Controls.Add(TextBoxBuscarFuncionario, 0, 0);
            PanelBarraDeBuscar.Location = new Point(181, 12);
            PanelBarraDeBuscar.Margin = new Padding(0);
            PanelBarraDeBuscar.Name = "PanelBarraDeBuscar";
            PanelBarraDeBuscar.RowCount = 1;
            PanelBarraDeBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelBarraDeBuscar.Size = new Size(410, 35);
            PanelBarraDeBuscar.TabIndex = 5;
            // 
            // BtnLimparBusca
            // 
            BtnLimparBusca.Location = new Point(381, 3);
            BtnLimparBusca.Name = "BtnLimparBusca";
            BtnLimparBusca.Size = new Size(24, 27);
            BtnLimparBusca.TabIndex = 2;
            BtnLimparBusca.Text = "X";
            BtnLimparBusca.UseVisualStyleBackColor = true;
            BtnLimparBusca.Click += BtnLimparPesquisa_Click;
            // 
            // TextBoxBuscarFuncionario
            // 
            TextBoxBuscarFuncionario.Anchor = AnchorStyles.Left;
            TextBoxBuscarFuncionario.BackColor = SystemColors.Window;
            TextBoxBuscarFuncionario.BorderStyle = BorderStyle.None;
            TextBoxBuscarFuncionario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxBuscarFuncionario.Location = new Point(0, 6);
            TextBoxBuscarFuncionario.Margin = new Padding(0);
            TextBoxBuscarFuncionario.Name = "TextBoxBuscarFuncionario";
            TextBoxBuscarFuncionario.Size = new Size(378, 20);
            TextBoxBuscarFuncionario.TabIndex = 1;
            TextBoxBuscarFuncionario.TextChanged += TextBoxBuscarFuncionario_TextChanged;
            TextBoxBuscarFuncionario.KeyUp += TextBoxBuscarFuncionario_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(104, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 35);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContratoComboBox
            // 
            ContratoComboBox.Dock = DockStyle.Fill;
            ContratoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ContratoComboBox.FormattingEnabled = true;
            ContratoComboBox.Location = new Point(674, 15);
            ContratoComboBox.Name = "ContratoComboBox";
            ContratoComboBox.Size = new Size(95, 28);
            ContratoComboBox.TabIndex = 7;
            ContratoComboBox.SelectedIndexChanged += ContratoComboBox_SelectedIndexChanged;
            // 
            // LabelContrato
            // 
            LabelContrato.AutoSize = true;
            LabelContrato.Dock = DockStyle.Fill;
            LabelContrato.Location = new Point(594, 12);
            LabelContrato.Name = "LabelContrato";
            LabelContrato.Size = new Size(74, 35);
            LabelContrato.TabIndex = 8;
            LabelContrato.Text = "Contrato:";
            LabelContrato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PanelControles
            // 
            PanelControles.BackColor = SystemColors.ActiveCaption;
            PanelControles.Controls.Add(BtnRemoverFuncionario);
            PanelControles.Controls.Add(BtnEditarFuncionario);
            PanelControles.Controls.Add(BtnNovoFuncionario);
            PanelControles.Dock = DockStyle.Fill;
            PanelControles.Location = new Point(3, 607);
            PanelControles.Name = "PanelControles";
            PanelControles.Size = new Size(1056, 63);
            PanelControles.TabIndex = 3;
            // 
            // BtnRemoverFuncionario
            // 
            BtnRemoverFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRemoverFuncionario.BackColor = Color.White;
            BtnRemoverFuncionario.Location = new Point(864, 5);
            BtnRemoverFuncionario.MaximumSize = new Size(200, 60);
            BtnRemoverFuncionario.MinimumSize = new Size(183, 53);
            BtnRemoverFuncionario.Name = "BtnRemoverFuncionario";
            BtnRemoverFuncionario.Size = new Size(183, 54);
            BtnRemoverFuncionario.TabIndex = 2;
            BtnRemoverFuncionario.Text = "Excluir";
            BtnRemoverFuncionario.UseVisualStyleBackColor = false;
            BtnRemoverFuncionario.Visible = false;
            BtnRemoverFuncionario.Click += BtnRemoverFuncionario_Click;
            // 
            // BtnEditarFuncionario
            // 
            BtnEditarFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEditarFuncionario.BackColor = Color.White;
            BtnEditarFuncionario.Location = new Point(669, 5);
            BtnEditarFuncionario.MaximumSize = new Size(200, 60);
            BtnEditarFuncionario.MinimumSize = new Size(183, 53);
            BtnEditarFuncionario.Name = "BtnEditarFuncionario";
            BtnEditarFuncionario.Size = new Size(183, 54);
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
            BtnNovoFuncionario.Size = new Size(183, 54);
            BtnNovoFuncionario.TabIndex = 0;
            BtnNovoFuncionario.Text = "Novo";
            BtnNovoFuncionario.UseVisualStyleBackColor = false;
            BtnNovoFuncionario.Visible = false;
            BtnNovoFuncionario.Click += BtnNovoFuncionario_Click;
            // 
            // DgvFuncionarios
            // 
            DgvFuncionarios.AllowUserToOrderColumns = true;
            DgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle1;
            DgvFuncionarios.Dock = DockStyle.Fill;
            DgvFuncionarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvFuncionarios.Location = new Point(3, 83);
            DgvFuncionarios.Name = "DgvFuncionarios";
            DgvFuncionarios.RowHeadersWidth = 51;
            DgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvFuncionarios.Size = new Size(1056, 518);
            DgvFuncionarios.TabIndex = 0;
            DgvFuncionarios.CellFormatting += DgvFuncionarios_CellFormatting;
            DgvFuncionarios.CellMouseDoubleClick += DgvFuncionarios_CellMouseDoubleClick;
            // 
            // LabelNenhumFuncErro
            // 
            LabelNenhumFuncErro.AutoSize = true;
            LabelNenhumFuncErro.Dock = DockStyle.Left;
            LabelNenhumFuncErro.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            LabelNenhumFuncErro.ForeColor = Color.Red;
            LabelNenhumFuncErro.Location = new Point(3, 60);
            LabelNenhumFuncErro.Name = "LabelNenhumFuncErro";
            LabelNenhumFuncErro.Size = new Size(0, 20);
            LabelNenhumFuncErro.TabIndex = 5;
            LabelNenhumFuncErro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(mainTable);
            MinimumSize = new Size(940, 650);
            Name = "FormTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            Load += FormTelaPrincipal_Load;
            mainTable.ResumeLayout(false);
            mainTable.PerformLayout();
            PanelBuscar.ResumeLayout(false);
            PanelBuscar.PerformLayout();
            PanelBarraDeBuscar.ResumeLayout(false);
            PanelBarraDeBuscar.PerformLayout();
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
        private TableLayoutPanel PanelBuscar;
        private TextBox TextBoxBuscarFuncionario;
        private Button BtnAtualizarDgv;
        private Button TelaInicialButton;
        private Button BtnLimparBusca;
        private Button BtnRealizarPesquisa;
        private Label LabelNenhumFuncErro;
        private TableLayoutPanel PanelBarraDeBuscar;
        private Label label1;
        private ComboBox ContratoComboBox;
        private Label LabelContrato;
    }
}