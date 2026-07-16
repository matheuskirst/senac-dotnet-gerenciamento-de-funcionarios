namespace GerenciamentoDeFuncionarios.views
{
    partial class FormCadastroFuncionario
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
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutLeft = new TableLayoutPanel();
            panelNomeFunc = new Panel();
            LabelCadastroNome = new Label();
            TxtBoxCadastroNome = new TextBox();
            panelCpfFunc = new Panel();
            LabelCadastroCpf = new Label();
            MTxtBoxCadastroCpf = new MaskedTextBox();
            panelEmailFunc = new Panel();
            LabelCadastroEmail = new Label();
            TxtBoxCadastroEmail = new TextBox();
            panelSalarioFunc = new Panel();
            TxtBoxCadastroSalario = new TextBox();
            LabelCadastroSalario = new Label();
            labelErro = new Label();
            tableLayoutRight = new TableLayoutPanel();
            GroupBoxSexo = new GroupBox();
            RadioBtnMasculino = new RadioButton();
            RadioBtnFeminino = new RadioButton();
            GroupBoxContrato = new GroupBox();
            RadioBtnContratoClt = new RadioButton();
            RadioBtnContratoPj = new RadioButton();
            RadioBtnContratoAutonomo = new RadioButton();
            BtnCadastroSalvar = new Button();
            tableLayoutMain.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            panelNomeFunc.SuspendLayout();
            panelCpfFunc.SuspendLayout();
            panelEmailFunc.SuspendLayout();
            panelSalarioFunc.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            GroupBoxSexo.SuspendLayout();
            GroupBoxContrato.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutMain.Controls.Add(tableLayoutLeft, 1, 1);
            tableLayoutMain.Controls.Add(tableLayoutRight, 2, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMain.Size = new Size(824, 581);
            tableLayoutMain.TabIndex = 0;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(panelNomeFunc, 0, 0);
            tableLayoutLeft.Controls.Add(panelCpfFunc, 0, 1);
            tableLayoutLeft.Controls.Add(panelEmailFunc, 0, 2);
            tableLayoutLeft.Controls.Add(panelSalarioFunc, 0, 3);
            tableLayoutLeft.Controls.Add(labelErro, 0, 4);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(23, 32);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 5;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutLeft.Size = new Size(509, 516);
            tableLayoutLeft.TabIndex = 0;
            // 
            // panelNomeFunc
            // 
            panelNomeFunc.Controls.Add(LabelCadastroNome);
            panelNomeFunc.Controls.Add(TxtBoxCadastroNome);
            panelNomeFunc.Dock = DockStyle.Fill;
            panelNomeFunc.Location = new Point(3, 3);
            panelNomeFunc.Name = "panelNomeFunc";
            panelNomeFunc.Size = new Size(503, 94);
            panelNomeFunc.TabIndex = 0;
            // 
            // LabelCadastroNome
            // 
            LabelCadastroNome.AutoSize = true;
            LabelCadastroNome.Font = new Font("Segoe UI", 10.8F);
            LabelCadastroNome.Location = new Point(11, 17);
            LabelCadastroNome.Name = "LabelCadastroNome";
            LabelCadastroNome.Size = new Size(65, 25);
            LabelCadastroNome.TabIndex = 0;
            LabelCadastroNome.Text = "Nome:";
            // 
            // TxtBoxCadastroNome
            // 
            TxtBoxCadastroNome.Font = new Font("Segoe UI", 10.8F);
            TxtBoxCadastroNome.Location = new Point(11, 53);
            TxtBoxCadastroNome.Name = "TxtBoxCadastroNome";
            TxtBoxCadastroNome.PlaceholderText = "Ex: João da Silva";
            TxtBoxCadastroNome.Size = new Size(365, 31);
            TxtBoxCadastroNome.TabIndex = 1;
            // 
            // panelCpfFunc
            // 
            panelCpfFunc.Controls.Add(LabelCadastroCpf);
            panelCpfFunc.Controls.Add(MTxtBoxCadastroCpf);
            panelCpfFunc.Dock = DockStyle.Fill;
            panelCpfFunc.Location = new Point(3, 103);
            panelCpfFunc.Name = "panelCpfFunc";
            panelCpfFunc.Size = new Size(503, 94);
            panelCpfFunc.TabIndex = 1;
            // 
            // LabelCadastroCpf
            // 
            LabelCadastroCpf.AutoSize = true;
            LabelCadastroCpf.Font = new Font("Segoe UI", 10.8F);
            LabelCadastroCpf.Location = new Point(11, 17);
            LabelCadastroCpf.Name = "LabelCadastroCpf";
            LabelCadastroCpf.Size = new Size(46, 25);
            LabelCadastroCpf.TabIndex = 0;
            LabelCadastroCpf.Text = "CPF:";
            // 
            // MTxtBoxCadastroCpf
            // 
            MTxtBoxCadastroCpf.Location = new Point(11, 55);
            MTxtBoxCadastroCpf.Mask = "000\\.000\\.000\\-00";
            MTxtBoxCadastroCpf.Name = "MTxtBoxCadastroCpf";
            MTxtBoxCadastroCpf.Size = new Size(365, 27);
            MTxtBoxCadastroCpf.TabIndex = 0;
            MTxtBoxCadastroCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxtBoxCadastroCpf.KeyPress += MTxtBoxCadastroCpf_KeyPress;
            // 
            // panelEmailFunc
            // 
            panelEmailFunc.Controls.Add(LabelCadastroEmail);
            panelEmailFunc.Controls.Add(TxtBoxCadastroEmail);
            panelEmailFunc.Dock = DockStyle.Fill;
            panelEmailFunc.Location = new Point(3, 203);
            panelEmailFunc.Name = "panelEmailFunc";
            panelEmailFunc.Size = new Size(503, 94);
            panelEmailFunc.TabIndex = 2;
            // 
            // LabelCadastroEmail
            // 
            LabelCadastroEmail.AutoSize = true;
            LabelCadastroEmail.Font = new Font("Segoe UI", 10.8F);
            LabelCadastroEmail.Location = new Point(11, 17);
            LabelCadastroEmail.Name = "LabelCadastroEmail";
            LabelCadastroEmail.Size = new Size(65, 25);
            LabelCadastroEmail.TabIndex = 0;
            LabelCadastroEmail.Text = "E-mail:";
            // 
            // TxtBoxCadastroEmail
            // 
            TxtBoxCadastroEmail.Font = new Font("Segoe UI", 10.8F);
            TxtBoxCadastroEmail.Location = new Point(11, 53);
            TxtBoxCadastroEmail.Name = "TxtBoxCadastroEmail";
            TxtBoxCadastroEmail.PlaceholderText = "Ex: joao.silva@email.com";
            TxtBoxCadastroEmail.Size = new Size(365, 31);
            TxtBoxCadastroEmail.TabIndex = 0;
            // 
            // panelSalarioFunc
            // 
            panelSalarioFunc.Controls.Add(TxtBoxCadastroSalario);
            panelSalarioFunc.Controls.Add(LabelCadastroSalario);
            panelSalarioFunc.Dock = DockStyle.Fill;
            panelSalarioFunc.Location = new Point(3, 303);
            panelSalarioFunc.Name = "panelSalarioFunc";
            panelSalarioFunc.Size = new Size(503, 94);
            panelSalarioFunc.TabIndex = 3;
            // 
            // TxtBoxCadastroSalario
            // 
            TxtBoxCadastroSalario.Location = new Point(11, 53);
            TxtBoxCadastroSalario.Name = "TxtBoxCadastroSalario";
            TxtBoxCadastroSalario.ReadOnly = true;
            TxtBoxCadastroSalario.Size = new Size(365, 27);
            TxtBoxCadastroSalario.TabIndex = 1;
            TxtBoxCadastroSalario.KeyDown += TxtBoxCadastroSalario_KeyDown;
            TxtBoxCadastroSalario.KeyPress += TxtBoxCadastroSalario_KeyPress;
            // 
            // LabelCadastroSalario
            // 
            LabelCadastroSalario.AutoSize = true;
            LabelCadastroSalario.Font = new Font("Segoe UI", 10.8F);
            LabelCadastroSalario.Location = new Point(11, 17);
            LabelCadastroSalario.Name = "LabelCadastroSalario";
            LabelCadastroSalario.Size = new Size(69, 25);
            LabelCadastroSalario.TabIndex = 0;
            LabelCadastroSalario.Text = "Salário:";
            // 
            // labelErro
            // 
            labelErro.AutoEllipsis = true;
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErro.ForeColor = Color.Red;
            labelErro.Location = new Point(3, 400);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 25);
            labelErro.TabIndex = 4;
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.Controls.Add(GroupBoxSexo, 0, 0);
            tableLayoutRight.Controls.Add(GroupBoxContrato, 0, 1);
            tableLayoutRight.Controls.Add(BtnCadastroSalvar, 0, 3);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(538, 32);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 4;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRight.Size = new Size(261, 516);
            tableLayoutRight.TabIndex = 1;
            // 
            // GroupBoxSexo
            // 
            GroupBoxSexo.Controls.Add(RadioBtnMasculino);
            GroupBoxSexo.Controls.Add(RadioBtnFeminino);
            GroupBoxSexo.Dock = DockStyle.Fill;
            GroupBoxSexo.Location = new Point(3, 3);
            GroupBoxSexo.Name = "GroupBoxSexo";
            GroupBoxSexo.Size = new Size(255, 94);
            GroupBoxSexo.TabIndex = 0;
            GroupBoxSexo.TabStop = false;
            GroupBoxSexo.Text = "Sexo:";
            // 
            // RadioBtnMasculino
            // 
            RadioBtnMasculino.AutoSize = true;
            RadioBtnMasculino.Checked = true;
            RadioBtnMasculino.Location = new Point(11, 40);
            RadioBtnMasculino.Name = "RadioBtnMasculino";
            RadioBtnMasculino.Size = new Size(97, 24);
            RadioBtnMasculino.TabIndex = 0;
            RadioBtnMasculino.TabStop = true;
            RadioBtnMasculino.Text = "Masculino";
            RadioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // RadioBtnFeminino
            // 
            RadioBtnFeminino.AutoSize = true;
            RadioBtnFeminino.Location = new Point(115, 40);
            RadioBtnFeminino.Name = "RadioBtnFeminino";
            RadioBtnFeminino.Size = new Size(91, 24);
            RadioBtnFeminino.TabIndex = 1;
            RadioBtnFeminino.Text = "Feminino";
            RadioBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // GroupBoxContrato
            // 
            GroupBoxContrato.Controls.Add(RadioBtnContratoClt);
            GroupBoxContrato.Controls.Add(RadioBtnContratoPj);
            GroupBoxContrato.Controls.Add(RadioBtnContratoAutonomo);
            GroupBoxContrato.Dock = DockStyle.Fill;
            GroupBoxContrato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxContrato.Location = new Point(3, 103);
            GroupBoxContrato.Name = "GroupBoxContrato";
            GroupBoxContrato.Size = new Size(255, 94);
            GroupBoxContrato.TabIndex = 1;
            GroupBoxContrato.TabStop = false;
            GroupBoxContrato.Text = "Tipo de Contrato";
            // 
            // RadioBtnContratoClt
            // 
            RadioBtnContratoClt.AutoSize = true;
            RadioBtnContratoClt.Checked = true;
            RadioBtnContratoClt.Location = new Point(11, 43);
            RadioBtnContratoClt.Name = "RadioBtnContratoClt";
            RadioBtnContratoClt.Size = new Size(53, 24);
            RadioBtnContratoClt.TabIndex = 0;
            RadioBtnContratoClt.TabStop = true;
            RadioBtnContratoClt.Text = "CLT";
            RadioBtnContratoClt.UseVisualStyleBackColor = true;
            // 
            // RadioBtnContratoPj
            // 
            RadioBtnContratoPj.AutoSize = true;
            RadioBtnContratoPj.Location = new Point(71, 43);
            RadioBtnContratoPj.Name = "RadioBtnContratoPj";
            RadioBtnContratoPj.Size = new Size(42, 24);
            RadioBtnContratoPj.TabIndex = 1;
            RadioBtnContratoPj.Text = "PJ";
            RadioBtnContratoPj.UseVisualStyleBackColor = true;
            // 
            // RadioBtnContratoAutonomo
            // 
            RadioBtnContratoAutonomo.AutoSize = true;
            RadioBtnContratoAutonomo.Location = new Point(127, 43);
            RadioBtnContratoAutonomo.Name = "RadioBtnContratoAutonomo";
            RadioBtnContratoAutonomo.Size = new Size(101, 24);
            RadioBtnContratoAutonomo.TabIndex = 2;
            RadioBtnContratoAutonomo.Text = "Autônomo";
            RadioBtnContratoAutonomo.UseVisualStyleBackColor = true;
            // 
            // BtnCadastroSalvar
            // 
            BtnCadastroSalvar.Anchor = AnchorStyles.None;
            BtnCadastroSalvar.Location = new Point(66, 464);
            BtnCadastroSalvar.Name = "BtnCadastroSalvar";
            BtnCadastroSalvar.Size = new Size(129, 49);
            BtnCadastroSalvar.TabIndex = 3;
            BtnCadastroSalvar.Text = "Salvar";
            BtnCadastroSalvar.UseVisualStyleBackColor = true;
            BtnCadastroSalvar.Click += btnSalvarFuncionario_Click;
            // 
            // FormCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 581);
            Controls.Add(tableLayoutMain);
            MinimumSize = new Size(840, 618);
            Name = "FormCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Funcionario";
            tableLayoutMain.ResumeLayout(false);
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutLeft.PerformLayout();
            panelNomeFunc.ResumeLayout(false);
            panelNomeFunc.PerformLayout();
            panelCpfFunc.ResumeLayout(false);
            panelCpfFunc.PerformLayout();
            panelEmailFunc.ResumeLayout(false);
            panelEmailFunc.PerformLayout();
            panelSalarioFunc.ResumeLayout(false);
            panelSalarioFunc.PerformLayout();
            tableLayoutRight.ResumeLayout(false);
            GroupBoxSexo.ResumeLayout(false);
            GroupBoxSexo.PerformLayout();
            GroupBoxContrato.ResumeLayout(false);
            GroupBoxContrato.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutLeft;
        private Panel panelNomeFunc;
        private Panel panelEmailFunc;
        private TextBox TxtBoxCadastroEmail;
        private Label LabelCadastroEmail;
        private TextBox TxtBoxCadastroNome;
        private Label LabelCadastroNome;
        private Panel panelSalarioFunc;
        private Label LabelCadastroSalario;
        private TableLayoutPanel tableLayoutRight;
        private GroupBox GroupBoxSexo;
        private RadioButton RadioBtnFeminino;
        private RadioButton RadioBtnMasculino;
        private GroupBox GroupBoxContrato;
        private RadioButton RadioBtnContratoAutonomo;
        private RadioButton RadioBtnContratoClt;
        private RadioButton RadioBtnContratoPj;
        private Button BtnCadastroSalvar;
        private Panel panelCpfFunc;
        private Label LabelCadastroCpf;
        private MaskedTextBox MTxtBoxCadastroCpf;
        private Label labelErro;
        private TextBox TxtBoxCadastroSalario;
    }
}