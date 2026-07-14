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
            tableLayoutMain.Margin = new Padding(3, 2, 3, 2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMain.Size = new Size(721, 436);
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
            tableLayoutLeft.Location = new Point(21, 23);
            tableLayoutLeft.Margin = new Padding(3, 2, 3, 2);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 5;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutLeft.Size = new Size(444, 388);
            tableLayoutLeft.TabIndex = 0;
            // 
            // panelNomeFunc
            // 
            panelNomeFunc.Controls.Add(labelNome);
            panelNomeFunc.Controls.Add(txtBoxFuncNome);
            panelNomeFunc.Dock = DockStyle.Fill;
            panelNomeFunc.Location = new Point(3, 2);
            panelNomeFunc.Margin = new Padding(3, 2, 3, 2);
            panelNomeFunc.Name = "panelNomeFunc";
            panelNomeFunc.Size = new Size(438, 71);
            panelNomeFunc.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 10.8F);
            labelNome.Location = new Point(10, 13);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // txtBoxFuncNome
            // 
            txtBoxFuncNome.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncNome.Location = new Point(10, 40);
            txtBoxFuncNome.Margin = new Padding(3, 2, 3, 2);
            txtBoxFuncNome.Name = "txtBoxFuncNome";
            txtBoxFuncNome.Size = new Size(320, 27);
            txtBoxFuncNome.TabIndex = 1;
            // 
            // panelCpfFunc
            // 
            panelCpfFunc.Controls.Add(labelCpf);
            panelCpfFunc.Controls.Add(mTxtBoxCpf);
            panelCpfFunc.Dock = DockStyle.Fill;
            panelCpfFunc.Location = new Point(3, 77);
            panelCpfFunc.Margin = new Padding(3, 2, 3, 2);
            panelCpfFunc.Name = "panelCpfFunc";
            panelCpfFunc.Size = new Size(438, 71);
            panelCpfFunc.TabIndex = 1;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 10.8F);
            labelCpf.Location = new Point(10, 13);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(36, 20);
            labelCpf.TabIndex = 0;
            labelCpf.Text = "CPF:";
            // 
            // mTxtBoxCpf
            // 
            mTxtBoxCpf.Location = new Point(10, 41);
            mTxtBoxCpf.Margin = new Padding(3, 2, 3, 2);
            mTxtBoxCpf.Mask = "000\\.000\\.000\\-00";
            mTxtBoxCpf.Name = "mTxtBoxCpf";
            mTxtBoxCpf.Size = new Size(320, 23);
            mTxtBoxCpf.TabIndex = 0;
            mTxtBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // panelEmailFunc
            // 
            panelEmailFunc.Controls.Add(labelEmail);
            panelEmailFunc.Controls.Add(txtBoxFuncEmail);
            panelEmailFunc.Dock = DockStyle.Fill;
            panelEmailFunc.Location = new Point(3, 152);
            panelEmailFunc.Margin = new Padding(3, 2, 3, 2);
            panelEmailFunc.Name = "panelEmailFunc";
            panelEmailFunc.Size = new Size(438, 71);
            panelEmailFunc.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F);
            labelEmail.Location = new Point(10, 13);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 20);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "E-mail:";
            // 
            // txtBoxFuncEmail
            // 
            txtBoxFuncEmail.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncEmail.Location = new Point(10, 40);
            txtBoxFuncEmail.Margin = new Padding(3, 2, 3, 2);
            txtBoxFuncEmail.Name = "txtBoxFuncEmail";
            txtBoxFuncEmail.Size = new Size(320, 27);
            txtBoxFuncEmail.TabIndex = 0;
            // 
            // panelSalarioFunc
            // 
            panelSalarioFunc.Controls.Add(txtBoxFuncSalario);
            panelSalarioFunc.Controls.Add(labelSalario);
            panelSalarioFunc.Dock = DockStyle.Fill;
            panelSalarioFunc.Location = new Point(3, 227);
            panelSalarioFunc.Margin = new Padding(3, 2, 3, 2);
            panelSalarioFunc.Name = "panelSalarioFunc";
            panelSalarioFunc.Size = new Size(438, 71);
            panelSalarioFunc.TabIndex = 3;
            // 
            // txtBoxFuncSalario
            // 
            txtBoxFuncSalario.Location = new Point(10, 40);
            txtBoxFuncSalario.Margin = new Padding(3, 2, 3, 2);
            txtBoxFuncSalario.Name = "txtBoxFuncSalario";
            txtBoxFuncSalario.Size = new Size(320, 23);
            txtBoxFuncSalario.TabIndex = 1;
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Font = new Font("Segoe UI", 10.8F);
            labelSalario.Location = new Point(10, 13);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(58, 20);
            labelSalario.TabIndex = 0;
            labelSalario.Text = "Salário:";
            // 
            // labelErro
            // 
            labelErro.AutoEllipsis = true;
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErro.ForeColor = Color.Red;
            labelErro.Location = new Point(3, 300);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 20);
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
            tableLayoutRight.Location = new Point(471, 23);
            tableLayoutRight.Margin = new Padding(3, 2, 3, 2);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 4;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutRight.Size = new Size(228, 388);
            tableLayoutRight.TabIndex = 1;
            // 
            // groupBoxSexo
            // 
            groupBoxSexo.Controls.Add(radioBtnMasculino);
            groupBoxSexo.Controls.Add(radioBtnFeminino);
            groupBoxSexo.Dock = DockStyle.Fill;
            groupBoxSexo.Location = new Point(3, 2);
            groupBoxSexo.Margin = new Padding(3, 2, 3, 2);
            groupBoxSexo.Name = "groupBoxSexo";
            groupBoxSexo.Padding = new Padding(3, 2, 3, 2);
            groupBoxSexo.Size = new Size(222, 71);
            groupBoxSexo.TabIndex = 0;
            groupBoxSexo.TabStop = false;
            groupBoxSexo.Text = "Sexo:";
            // 
            // radioBtnMasculino
            // 
            radioBtnMasculino.AutoSize = true;
            radioBtnMasculino.Checked = true;
            radioBtnMasculino.Location = new Point(10, 30);
            radioBtnMasculino.Margin = new Padding(3, 2, 3, 2);
            radioBtnMasculino.Name = "radioBtnMasculino";
            radioBtnMasculino.Size = new Size(80, 19);
            radioBtnMasculino.TabIndex = 0;
            radioBtnMasculino.TabStop = true;
            radioBtnMasculino.Text = "Masculino";
            radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // radioBtnFeminino
            // 
            radioBtnFeminino.AutoSize = true;
            radioBtnFeminino.Location = new Point(101, 30);
            radioBtnFeminino.Margin = new Padding(3, 2, 3, 2);
            radioBtnFeminino.Name = "radioBtnFeminino";
            radioBtnFeminino.Size = new Size(75, 19);
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
            groupBoxContrato.Location = new Point(3, 77);
            groupBoxContrato.Margin = new Padding(3, 2, 3, 2);
            groupBoxContrato.Name = "groupBoxContrato";
            groupBoxContrato.Padding = new Padding(3, 2, 3, 2);
            groupBoxContrato.Size = new Size(222, 71);
            groupBoxContrato.TabIndex = 1;
            groupBoxContrato.TabStop = false;
            groupBoxContrato.Text = "Tipo de Contrato";
            // 
            // radioBtnContratoClt
            // 
            radioBtnContratoClt.AutoSize = true;
            radioBtnContratoClt.Checked = true;
            radioBtnContratoClt.Location = new Point(10, 32);
            radioBtnContratoClt.Margin = new Padding(3, 2, 3, 2);
            radioBtnContratoClt.Name = "radioBtnContratoClt";
            radioBtnContratoClt.Size = new Size(45, 19);
            radioBtnContratoClt.TabIndex = 0;
            radioBtnContratoClt.TabStop = true;
            radioBtnContratoClt.Text = "CLT";
            radioBtnContratoClt.UseVisualStyleBackColor = true;
            // 
            // radioBtnContratoPj
            // 
            radioBtnContratoPj.AutoSize = true;
            radioBtnContratoPj.Location = new Point(62, 32);
            radioBtnContratoPj.Margin = new Padding(3, 2, 3, 2);
            radioBtnContratoPj.Name = "radioBtnContratoPj";
            radioBtnContratoPj.Size = new Size(35, 19);
            radioBtnContratoPj.TabIndex = 1;
            radioBtnContratoPj.Text = "PJ";
            radioBtnContratoPj.UseVisualStyleBackColor = true;
            // 
            // radioBtnContratoAutonomo
            // 
            radioBtnContratoAutonomo.AutoSize = true;
            radioBtnContratoAutonomo.Location = new Point(111, 32);
            radioBtnContratoAutonomo.Margin = new Padding(3, 2, 3, 2);
            radioBtnContratoAutonomo.Name = "radioBtnContratoAutonomo";
            radioBtnContratoAutonomo.Size = new Size(83, 19);
            radioBtnContratoAutonomo.TabIndex = 2;
            radioBtnContratoAutonomo.Text = "Autônomo";
            radioBtnContratoAutonomo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarFuncionario
            // 
            btnSalvarFuncionario.Anchor = AnchorStyles.None;
            btnSalvarFuncionario.Location = new Point(57, 349);
            btnSalvarFuncionario.Margin = new Padding(3, 2, 3, 2);
            btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            btnSalvarFuncionario.Size = new Size(113, 37);
            btnSalvarFuncionario.TabIndex = 3;
            btnSalvarFuncionario.Text = "Salvar";
            btnSalvarFuncionario.UseVisualStyleBackColor = true;
            btnSalvarFuncionario.Click += btnSalvarFuncionario_Click;
            // 
            // FormCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 436);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(737, 475);
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