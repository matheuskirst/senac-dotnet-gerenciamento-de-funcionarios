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
            txtBoxFuncNome = new TextBox();
            label2 = new Label();
            panelEmailFunc = new Panel();
            txtBoxFuncEmail = new TextBox();
            label3 = new Label();
            panelSalarioFunc = new Panel();
            txtBoxFuncSalario = new TextBox();
            label4 = new Label();
            tableLayoutRight = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            radioBtnFeminino = new RadioButton();
            radioBtnMasculino = new RadioButton();
            groupBox2 = new GroupBox();
            radioBtnContratoPj = new RadioButton();
            radioBtnContratoAutonomo = new RadioButton();
            radioBtnContratoClt = new RadioButton();
            btnSalvarFuncionario = new Button();
            tableLayoutMain.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            panelNomeFunc.SuspendLayout();
            panelEmailFunc.SuspendLayout();
            panelSalarioFunc.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            tableLayoutMain.Size = new Size(802, 463);
            tableLayoutMain.TabIndex = 0;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(panelNomeFunc, 0, 0);
            tableLayoutLeft.Controls.Add(panelEmailFunc, 0, 1);
            tableLayoutLeft.Controls.Add(panelSalarioFunc, 0, 2);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(23, 26);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 4;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutLeft.Size = new Size(495, 410);
            tableLayoutLeft.TabIndex = 0;
            // 
            // panelNomeFunc
            // 
            panelNomeFunc.Controls.Add(txtBoxFuncNome);
            panelNomeFunc.Controls.Add(label2);
            panelNomeFunc.Dock = DockStyle.Fill;
            panelNomeFunc.Location = new Point(3, 3);
            panelNomeFunc.Name = "panelNomeFunc";
            panelNomeFunc.Size = new Size(489, 94);
            panelNomeFunc.TabIndex = 0;
            // 
            // txtBoxFuncNome
            // 
            txtBoxFuncNome.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncNome.Location = new Point(12, 54);
            txtBoxFuncNome.Name = "txtBoxFuncNome";
            txtBoxFuncNome.PlaceholderText = "Ex: João da Silva";
            txtBoxFuncNome.Size = new Size(365, 31);
            txtBoxFuncNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // panelEmailFunc
            // 
            panelEmailFunc.Controls.Add(txtBoxFuncEmail);
            panelEmailFunc.Controls.Add(label3);
            panelEmailFunc.Dock = DockStyle.Fill;
            panelEmailFunc.Location = new Point(3, 103);
            panelEmailFunc.Name = "panelEmailFunc";
            panelEmailFunc.Size = new Size(489, 94);
            panelEmailFunc.TabIndex = 3;
            // 
            // txtBoxFuncEmail
            // 
            txtBoxFuncEmail.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncEmail.Location = new Point(12, 54);
            txtBoxFuncEmail.Name = "txtBoxFuncEmail";
            txtBoxFuncEmail.PlaceholderText = "Ex: joao.silva@email.com";
            txtBoxFuncEmail.Size = new Size(365, 31);
            txtBoxFuncEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 0;
            label3.Text = "E-mail:";
            // 
            // panelSalarioFunc
            // 
            panelSalarioFunc.Controls.Add(txtBoxFuncSalario);
            panelSalarioFunc.Controls.Add(label4);
            panelSalarioFunc.Dock = DockStyle.Fill;
            panelSalarioFunc.Location = new Point(3, 203);
            panelSalarioFunc.Name = "panelSalarioFunc";
            panelSalarioFunc.Size = new Size(489, 94);
            panelSalarioFunc.TabIndex = 4;
            // 
            // txtBoxFuncSalario
            // 
            txtBoxFuncSalario.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncSalario.Location = new Point(12, 54);
            txtBoxFuncSalario.Name = "txtBoxFuncSalario";
            txtBoxFuncSalario.PlaceholderText = "Somente valores numéricos (Ex: 2000)";
            txtBoxFuncSalario.Size = new Size(365, 31);
            txtBoxFuncSalario.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(12, 17);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 0;
            label4.Text = "Salário:";
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.Controls.Add(groupBox1, 0, 0);
            tableLayoutRight.Controls.Add(groupBox2, 0, 1);
            tableLayoutRight.Controls.Add(btnSalvarFuncionario, 0, 3);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(524, 26);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 4;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutRight.Size = new Size(254, 410);
            tableLayoutRight.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnFeminino);
            groupBox1.Controls.Add(radioBtnMasculino);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 94);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo:";
            // 
            // radioBtnFeminino
            // 
            radioBtnFeminino.AutoSize = true;
            radioBtnFeminino.Location = new Point(115, 40);
            radioBtnFeminino.Name = "radioBtnFeminino";
            radioBtnFeminino.Size = new Size(91, 24);
            radioBtnFeminino.TabIndex = 1;
            radioBtnFeminino.TabStop = true;
            radioBtnFeminino.Text = "Feminino";
            radioBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculino
            // 
            radioBtnMasculino.AutoSize = true;
            radioBtnMasculino.Location = new Point(12, 40);
            radioBtnMasculino.Name = "radioBtnMasculino";
            radioBtnMasculino.Size = new Size(97, 24);
            radioBtnMasculino.TabIndex = 0;
            radioBtnMasculino.TabStop = true;
            radioBtnMasculino.Text = "Masculino";
            radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnContratoPj);
            groupBox2.Controls.Add(radioBtnContratoAutonomo);
            groupBox2.Controls.Add(radioBtnContratoClt);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 94);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Contrato";
            // 
            // radioBtnContratoPj
            // 
            radioBtnContratoPj.AutoSize = true;
            radioBtnContratoPj.Location = new Point(71, 42);
            radioBtnContratoPj.Name = "radioBtnContratoPj";
            radioBtnContratoPj.Size = new Size(42, 24);
            radioBtnContratoPj.TabIndex = 4;
            radioBtnContratoPj.TabStop = true;
            radioBtnContratoPj.Text = "PJ";
            radioBtnContratoPj.UseVisualStyleBackColor = true;
            // 
            // radioBtnContratoAutonomo
            // 
            radioBtnContratoAutonomo.AutoSize = true;
            radioBtnContratoAutonomo.Location = new Point(127, 42);
            radioBtnContratoAutonomo.Name = "radioBtnContratoAutonomo";
            radioBtnContratoAutonomo.Size = new Size(101, 24);
            radioBtnContratoAutonomo.TabIndex = 3;
            radioBtnContratoAutonomo.TabStop = true;
            radioBtnContratoAutonomo.Text = "Autônomo";
            radioBtnContratoAutonomo.UseVisualStyleBackColor = true;
            // 
            // radioBtnContratoClt
            // 
            radioBtnContratoClt.AutoSize = true;
            radioBtnContratoClt.Location = new Point(12, 42);
            radioBtnContratoClt.Name = "radioBtnContratoClt";
            radioBtnContratoClt.Size = new Size(53, 24);
            radioBtnContratoClt.TabIndex = 2;
            radioBtnContratoClt.TabStop = true;
            radioBtnContratoClt.Text = "CLT";
            radioBtnContratoClt.UseVisualStyleBackColor = true;
            // 
            // btnSalvarFuncionario
            // 
            btnSalvarFuncionario.Anchor = AnchorStyles.None;
            btnSalvarFuncionario.Location = new Point(62, 349);
            btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            btnSalvarFuncionario.Size = new Size(129, 50);
            btnSalvarFuncionario.TabIndex = 4;
            btnSalvarFuncionario.Text = "Salvar";
            btnSalvarFuncionario.UseVisualStyleBackColor = true;
            btnSalvarFuncionario.Click += btnSalvarFuncionario_Click;
            // 
            // FormCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 463);
            Controls.Add(tableLayoutMain);
            MinimumSize = new Size(820, 510);
            Name = "FormCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionario";
            tableLayoutMain.ResumeLayout(false);
            tableLayoutLeft.ResumeLayout(false);
            panelNomeFunc.ResumeLayout(false);
            panelNomeFunc.PerformLayout();
            panelEmailFunc.ResumeLayout(false);
            panelEmailFunc.PerformLayout();
            panelSalarioFunc.ResumeLayout(false);
            panelSalarioFunc.PerformLayout();
            tableLayoutRight.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutLeft;
        private Panel panelNomeFunc;
        private Panel panelEmailFunc;
        private TextBox txtBoxFuncEmail;
        private Label label3;
        private TextBox txtBoxFuncNome;
        private Label label2;
        private Panel panelSalarioFunc;
        private TextBox txtBoxFuncSalario;
        private Label label4;
        private TableLayoutPanel tableLayoutRight;
        private GroupBox groupBox1;
        private RadioButton radioBtnFeminino;
        private RadioButton radioBtnMasculino;
        private GroupBox groupBox2;
        private RadioButton radioBtnContratoAutonomo;
        private RadioButton radioBtnContratoClt;
        private RadioButton radioBtnContratoPj;
        private Button btnSalvarFuncionario;
    }
}