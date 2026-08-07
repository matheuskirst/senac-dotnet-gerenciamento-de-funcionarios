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
            components = new System.ComponentModel.Container();
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
            PesquisaToolTip = new ToolTip(components);
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
            mainTable.Margin = new Padding(3, 2, 3, 2);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 4;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            mainTable.Size = new Size(914, 461);
            mainTable.TabIndex = 0;
            // 
            // PanelBuscar
            // 
            PanelBuscar.ColumnCount = 9;
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 359F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
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
            PanelBuscar.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            PanelBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelBuscar.Size = new Size(914, 45);
            PanelBuscar.TabIndex = 4;
            // 
            // TelaInicialButton
            // 
            TelaInicialButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TelaInicialButton.Location = new Point(0, 9);
            TelaInicialButton.Margin = new Padding(0);
            TelaInicialButton.Name = "TelaInicialButton";
            TelaInicialButton.Size = new Size(88, 26);
            TelaInicialButton.TabIndex = 0;
            TelaInicialButton.Text = "Tela Inicial";
            TelaInicialButton.UseVisualStyleBackColor = true;
            TelaInicialButton.Click += TelaInicialButton_Click;
            // 
            // BtnAtualizarDgv
            // 
            BtnAtualizarDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAtualizarDgv.Location = new Point(723, 9);
            BtnAtualizarDgv.Margin = new Padding(0);
            BtnAtualizarDgv.Name = "BtnAtualizarDgv";
            BtnAtualizarDgv.Size = new Size(88, 26);
            BtnAtualizarDgv.TabIndex = 4;
            BtnAtualizarDgv.Text = "Atualizar";
            BtnAtualizarDgv.UseVisualStyleBackColor = true;
            BtnAtualizarDgv.Click += BtnAtualizarDgv_Click;
            // 
            // BtnRealizarPesquisa
            // 
            BtnRealizarPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnRealizarPesquisa.Location = new Point(662, 9);
            BtnRealizarPesquisa.Margin = new Padding(0);
            BtnRealizarPesquisa.Name = "BtnRealizarPesquisa";
            BtnRealizarPesquisa.Size = new Size(61, 26);
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
            PanelBarraDeBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            PanelBarraDeBuscar.Controls.Add(BtnLimparBusca, 1, 0);
            PanelBarraDeBuscar.Controls.Add(TextBoxBuscarFuncionario, 0, 0);
            PanelBarraDeBuscar.Location = new Point(158, 9);
            PanelBarraDeBuscar.Margin = new Padding(0);
            PanelBarraDeBuscar.Name = "PanelBarraDeBuscar";
            PanelBarraDeBuscar.RowCount = 1;
            PanelBarraDeBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelBarraDeBuscar.Size = new Size(359, 26);
            PanelBarraDeBuscar.TabIndex = 5;
            // 
            // BtnLimparBusca
            // 
            BtnLimparBusca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnLimparBusca.FlatAppearance.BorderSize = 0;
            BtnLimparBusca.FlatStyle = FlatStyle.Flat;
            BtnLimparBusca.Location = new Point(337, 0);
            BtnLimparBusca.Margin = new Padding(0);
            BtnLimparBusca.Name = "BtnLimparBusca";
            BtnLimparBusca.Size = new Size(20, 24);
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
            TextBoxBuscarFuncionario.Location = new Point(0, 4);
            TextBoxBuscarFuncionario.Margin = new Padding(0);
            TextBoxBuscarFuncionario.Name = "TextBoxBuscarFuncionario";
            TextBoxBuscarFuncionario.PlaceholderText = "Nome, CPF, Email...";
            TextBoxBuscarFuncionario.Size = new Size(331, 16);
            TextBoxBuscarFuncionario.TabIndex = 1;
            PesquisaToolTip.SetToolTip(TextBoxBuscarFuncionario, "Para pesquisar pela 'Matricula' digite: id:\"número matricula\"");
            TextBoxBuscarFuncionario.TextChanged += TextBoxBuscarFuncionario_TextChanged;
            TextBoxBuscarFuncionario.KeyUp += TextBoxBuscarFuncionario_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 26);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContratoComboBox
            // 
            ContratoComboBox.Dock = DockStyle.Fill;
            ContratoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ContratoComboBox.FormattingEnabled = true;
            ContratoComboBox.Location = new Point(577, 11);
            ContratoComboBox.Margin = new Padding(3, 2, 3, 2);
            ContratoComboBox.Name = "ContratoComboBox";
            ContratoComboBox.RightToLeft = RightToLeft.No;
            ContratoComboBox.Size = new Size(82, 23);
            ContratoComboBox.TabIndex = 7;
            ContratoComboBox.SelectedIndexChanged += ContratoComboBox_SelectedIndexChanged;
            // 
            // LabelContrato
            // 
            LabelContrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelContrato.AutoSize = true;
            LabelContrato.Location = new Point(517, 9);
            LabelContrato.Margin = new Padding(0);
            LabelContrato.Name = "LabelContrato";
            LabelContrato.Size = new Size(57, 26);
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
            PanelControles.Location = new Point(3, 411);
            PanelControles.Margin = new Padding(3, 2, 3, 2);
            PanelControles.Name = "PanelControles";
            PanelControles.Size = new Size(908, 48);
            PanelControles.TabIndex = 3;
            // 
            // BtnRemoverFuncionario
            // 
            BtnRemoverFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRemoverFuncionario.BackColor = Color.White;
            BtnRemoverFuncionario.Location = new Point(740, 4);
            BtnRemoverFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnRemoverFuncionario.MaximumSize = new Size(175, 45);
            BtnRemoverFuncionario.MinimumSize = new Size(160, 40);
            BtnRemoverFuncionario.Name = "BtnRemoverFuncionario";
            BtnRemoverFuncionario.Size = new Size(160, 41);
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
            BtnEditarFuncionario.Location = new Point(569, 4);
            BtnEditarFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnEditarFuncionario.MaximumSize = new Size(175, 45);
            BtnEditarFuncionario.MinimumSize = new Size(160, 40);
            BtnEditarFuncionario.Name = "BtnEditarFuncionario";
            BtnEditarFuncionario.Size = new Size(160, 41);
            BtnEditarFuncionario.TabIndex = 1;
            BtnEditarFuncionario.Text = "Editar";
            BtnEditarFuncionario.UseVisualStyleBackColor = false;
            BtnEditarFuncionario.Click += BtnEditarFuncionario_Click;
            // 
            // BtnNovoFuncionario
            // 
            BtnNovoFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNovoFuncionario.BackColor = Color.White;
            BtnNovoFuncionario.Location = new Point(3, 4);
            BtnNovoFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnNovoFuncionario.MaximumSize = new Size(175, 45);
            BtnNovoFuncionario.MinimumSize = new Size(160, 40);
            BtnNovoFuncionario.Name = "BtnNovoFuncionario";
            BtnNovoFuncionario.Size = new Size(160, 41);
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
            DgvFuncionarios.Location = new Point(3, 62);
            DgvFuncionarios.Margin = new Padding(3, 2, 3, 2);
            DgvFuncionarios.Name = "DgvFuncionarios";
            DgvFuncionarios.RowHeadersWidth = 51;
            DgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvFuncionarios.Size = new Size(908, 345);
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
            LabelNenhumFuncErro.Location = new Point(3, 45);
            LabelNenhumFuncErro.Name = "LabelNenhumFuncErro";
            LabelNenhumFuncErro.Size = new Size(0, 15);
            LabelNenhumFuncErro.TabIndex = 5;
            LabelNenhumFuncErro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 461);
            Controls.Add(mainTable);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(930, 500);
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
        private ToolTip PesquisaToolTip;
    }
}