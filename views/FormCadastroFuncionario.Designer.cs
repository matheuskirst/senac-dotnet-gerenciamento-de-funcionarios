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
            labelNome = new Label();
            txtBoxFuncNome = new TextBox();
            panelCpfFunc = new Panel();
            labelCpf = new Label();
            mTxtBoxCpf = new MaskedTextBox();
            panelEmailFunc = new Panel();
            labelEmail = new Label();
            txtBoxFuncEmail = new TextBox();
            panelSalarioFunc = new Panel();
            txtBoxFuncSalario = new TextBox();
            labelSalario = new Label();
            labelErro = new Label();
            tableLayoutRight = new TableLayoutPanel();
            groupBoxSexo = new GroupBox();
            radioBtnMasculino = new RadioButton();
            radioBtnFeminino = new RadioButton();
            groupBoxContrato = new GroupBox();
            radioBtnContratoClt = new RadioButton();
            radioBtnContratoPj = new RadioButton();
            radioBtnContratoAutonomo = new RadioButton();
            btnSalvarFuncionario = new Button();
            tableLayoutMain.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            panelNomeFunc.SuspendLayout();
            panelCpfFunc.SuspendLayout();
            panelEmailFunc.SuspendLayout();
            panelSalarioFunc.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            groupBoxSexo.SuspendLayout();
            groupBoxContrato.SuspendLayout();
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
            panelNomeFunc.Controls.Add(labelNome);
            panelNomeFunc.Controls.Add(txtBoxFuncNome);
            panelNomeFunc.Dock = DockStyle.Fill;
            panelNomeFunc.Location = new Point(3, 3);
            panelNomeFunc.Name = "panelNomeFunc";
            panelNomeFunc.Size = new Size(503, 94);
            panelNomeFunc.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 10.8F);
            labelNome.Location = new Point(11, 17);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(65, 25);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // txtBoxFuncNome
            // 
            txtBoxFuncNome.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncNome.Location = new Point(11, 53);
            txtBoxFuncNome.Name = "txtBoxFuncNome";
            txtBoxFuncNome.PlaceholderText = "Ex: João da Silva";
            txtBoxFuncNome.Size = new Size(365, 31);
            txtBoxFuncNome.TabIndex = 1;
            // 
            // panelCpfFunc
            // 
            panelCpfFunc.Controls.Add(labelCpf);
            panelCpfFunc.Controls.Add(mTxtBoxCpf);
            panelCpfFunc.Dock = DockStyle.Fill;
            panelCpfFunc.Location = new Point(3, 103);
            panelCpfFunc.Name = "panelCpfFunc";
            panelCpfFunc.Size = new Size(503, 94);
            panelCpfFunc.TabIndex = 1;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 10.8F);
            labelCpf.Location = new Point(11, 17);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(46, 25);
            labelCpf.TabIndex = 0;
            labelCpf.Text = "CPF:";
            // 
            // mTxtBoxCpf
            // 
            mTxtBoxCpf.Location = new Point(11, 55);
            mTxtBoxCpf.Mask = "000\\.000\\.000\\-00";
            mTxtBoxCpf.Name = "mTxtBoxCpf";
            mTxtBoxCpf.Size = new Size(365, 27);
            mTxtBoxCpf.TabIndex = 0;
            mTxtBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mTxtBoxCpf.KeyPress += mTxtBoxCpf_KeyPress;
            // 
            // panelEmailFunc
            // 
            panelEmailFunc.Controls.Add(labelEmail);
            panelEmailFunc.Controls.Add(txtBoxFuncEmail);
            panelEmailFunc.Dock = DockStyle.Fill;
            panelEmailFunc.Location = new Point(3, 203);
            panelEmailFunc.Name = "panelEmailFunc";
            panelEmailFunc.Size = new Size(503, 94);
            panelEmailFunc.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F);
            labelEmail.Location = new Point(11, 17);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(65, 25);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "E-mail:";
            // 
            // txtBoxFuncEmail
            // 
            txtBoxFuncEmail.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncEmail.Location = new Point(11, 53);
            txtBoxFuncEmail.Name = "txtBoxFuncEmail";
            txtBoxFuncEmail.PlaceholderText = "Ex: joao.silva@email.com";
            txtBoxFuncEmail.Size = new Size(365, 31);
            txtBoxFuncEmail.TabIndex = 0;
            // 
            // panelSalarioFunc
            // 
            panelSalarioFunc.Controls.Add(txtBoxFuncSalario);
            panelSalarioFunc.Controls.Add(labelSalario);
            panelSalarioFunc.Dock = DockStyle.Fill;
            panelSalarioFunc.Location = new Point(3, 303);
            panelSalarioFunc.Name = "panelSalarioFunc";
            panelSalarioFunc.Size = new Size(503, 94);
            panelSalarioFunc.TabIndex = 3;
            // 
            // txtBoxFuncSalario
            // 
            txtBoxFuncSalario.Location = new Point(11, 53);
            txtBoxFuncSalario.Name = "txtBoxFuncSalario";
            txtBoxFuncSalario.ReadOnly = true;
            txtBoxFuncSalario.Size = new Size(365, 27);
            txtBoxFuncSalario.TabIndex = 1;
            txtBoxFuncSalario.KeyDown += txtBoxFuncSalario_KeyDown;
            txtBoxFuncSalario.KeyPress += txtBoxFuncSalario_KeyPress;
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Font = new Font("Segoe UI", 10.8F);
            labelSalario.Location = new Point(11, 17);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(69, 25);
            labelSalario.TabIndex = 0;
            labelSalario.Text = "Salário:";
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
            tableLayoutRight.Controls.Add(groupBoxSexo, 0, 0);
            tableLayoutRight.Controls.Add(groupBoxContrato, 0, 1);
            tableLayoutRight.Controls.Add(btnSalvarFuncionario, 0, 3);
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
            // groupBoxSexo
            // 
            groupBoxSexo.Controls.Add(radioBtnMasculino);
            groupBoxSexo.Controls.Add(radioBtnFeminino);
            groupBoxSexo.Dock = DockStyle.Fill;
            groupBoxSexo.Location = new Point(3, 3);
            groupBoxSexo.Name = "groupBoxSexo";
            groupBoxSexo.Size = new Size(255, 94);
            groupBoxSexo.TabIndex = 0;
            groupBoxSexo.TabStop = false;
            groupBoxSexo.Text = "Sexo:";
            // 
            // radioBtnMasculino
            // 
            radioBtnMasculino.AutoSize = true;
            radioBtnMasculino.Checked = true;
            radioBtnMasculino.Location = new Point(11, 40);
            radioBtnMasculino.Name = "radioBtnMasculino";
            radioBtnMasculino.Size = new Size(97, 24);
            radioBtnMasculino.TabIndex = 0;
            radioBtnMasculino.TabStop = true;
            radioBtnMasculino.Text = "Masculino";
            radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // radioBtnFeminino
            // 
            radioBtnFeminino.AutoSize = true;
            radioBtnFeminino.Location = new Point(115, 40);
            radioBtnFeminino.Name = "radioBtnFeminino";
            radioBtnFeminino.Size = new Size(91, 24);
            radioBtnFeminino.TabIndex = 1;
            radioBtnFeminino.Text = "Feminino";
            radioBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBoxContrato
            // 
            groupBoxContrato.Controls.Add(radioBtnContratoClt);
            groupBoxContrato.Controls.Add(radioBtnContratoPj);
            groupBoxContrato.Controls.Add(radioBtnContratoAutonomo);
            groupBoxContrato.Dock = DockStyle.Fill;
            groupBoxContrato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxContrato.Location = new Point(3, 103);
            groupBoxContrato.Name = "groupBoxContrato";
            groupBoxContrato.Size = new Size(255, 94);
            groupBoxContrato.TabIndex = 1;
            groupBoxContrato.TabStop = false;
            groupBoxContrato.Text = "Tipo de Contrato";
            // 
            // radioBtnContratoClt
            // 
            radioBtnContratoClt.AutoSize = true;
            radioBtnContratoClt.Checked = true;
            radioBtnContratoClt.Location = new Point(11, 43);
            radioBtnContratoClt.Name = "radioBtnContratoClt";
            radioBtnContratoClt.Size = new Size(53, 24);
            radioBtnContratoClt.TabIndex = 0;
            radioBtnContratoClt.TabStop = true;
            radioBtnContratoClt.Text = "CLT";
            radioBtnContratoClt.UseVisualStyleBackColor = true;
            // 
            // radioBtnContratoPj
            // 
            radioBtnContratoPj.AutoSize = true;
            radioBtnContratoPj.Location = new Point(71, 43);
            radioBtnContratoPj.Name = "radioBtnContratoPj";
            radioBtnContratoPj.Size = new Size(42, 24);
            radioBtnContratoPj.TabIndex = 1;
            radioBtnContratoPj.Text = "PJ";
            radioBtnContratoPj.UseVisualStyleBackColor = true;
            // 
            // radioBtnContratoAutonomo
            // 
            radioBtnContratoAutonomo.AutoSize = true;
            radioBtnContratoAutonomo.Location = new Point(127, 43);
            radioBtnContratoAutonomo.Name = "radioBtnContratoAutonomo";
            radioBtnContratoAutonomo.Size = new Size(101, 24);
            radioBtnContratoAutonomo.TabIndex = 2;
            radioBtnContratoAutonomo.Text = "Autônomo";
            radioBtnContratoAutonomo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarFuncionario
            // 
            btnSalvarFuncionario.Anchor = AnchorStyles.None;
            btnSalvarFuncionario.Location = new Point(66, 464);
            btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            btnSalvarFuncionario.Size = new Size(129, 49);
            btnSalvarFuncionario.TabIndex = 3;
            btnSalvarFuncionario.Text = "Salvar";
            btnSalvarFuncionario.UseVisualStyleBackColor = true;
            btnSalvarFuncionario.Click += btnSalvarFuncionario_Click;
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
            groupBoxSexo.ResumeLayout(false);
            groupBoxSexo.PerformLayout();
            groupBoxContrato.ResumeLayout(false);
            groupBoxContrato.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutLeft;
        private Panel panelNomeFunc;
        private Panel panelEmailFunc;
        private TextBox txtBoxFuncEmail;
        private Label labelEmail;
        private TextBox txtBoxFuncNome;
        private Label labelNome;
        private Panel panelSalarioFunc;
        private Label labelSalario;
        private TableLayoutPanel tableLayoutRight;
        private GroupBox groupBoxSexo;
        private RadioButton radioBtnFeminino;
        private RadioButton radioBtnMasculino;
        private GroupBox groupBoxContrato;
        private RadioButton radioBtnContratoAutonomo;
        private RadioButton radioBtnContratoClt;
        private RadioButton radioBtnContratoPj;
        private Button btnSalvarFuncionario;
        private Panel panelCpfFunc;
        private Label labelCpf;
        private MaskedTextBox mTxtBoxCpf;
        private Label labelErro;
        private TextBox txtBoxFuncSalario;
    }
}