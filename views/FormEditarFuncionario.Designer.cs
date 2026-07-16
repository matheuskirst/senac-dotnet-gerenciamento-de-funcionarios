namespace GerenciamentoDeFuncionarios.views
{
    partial class FormEditarFuncionario
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
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            GroupBoxEditarNome = new GroupBox();
            TextBoxEditarNome = new TextBox();
            GroupBoxEditarCpf = new GroupBox();
            TextBoxEditarCpf = new TextBox();
            GroupBoxEditarTipoContrato = new GroupBox();
            RadioBtnEditarAutonomo = new RadioButton();
            RadioBtnEditarPj = new RadioButton();
            RadioBtnEditarClt = new RadioButton();
            GroupBoxEditarSexo = new GroupBox();
            RadioBtnEditarFeminino = new RadioButton();
            RadioBtnEditarMasculino = new RadioButton();
            GroupBoxEditarSalario = new GroupBox();
            TextBoxEditarSalario = new TextBox();
            GroupBoxEditarEmail = new GroupBox();
            TextBoxEditarEmail = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnEditarSalvar = new Button();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            GroupBoxEditarNome.SuspendLayout();
            GroupBoxEditarCpf.SuspendLayout();
            GroupBoxEditarTipoContrato.SuspendLayout();
            GroupBoxEditarSexo.SuspendLayout();
            GroupBoxEditarSalario.SuspendLayout();
            GroupBoxEditarEmail.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelMain.Size = new Size(432, 523);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(GroupBoxEditarNome, 0, 0);
            tableLayoutPanel1.Controls.Add(GroupBoxEditarCpf, 0, 1);
            tableLayoutPanel1.Controls.Add(GroupBoxEditarTipoContrato, 0, 5);
            tableLayoutPanel1.Controls.Add(GroupBoxEditarSexo, 0, 4);
            tableLayoutPanel1.Controls.Add(GroupBoxEditarSalario, 0, 3);
            tableLayoutPanel1.Controls.Add(GroupBoxEditarEmail, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(24, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(382, 464);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // GroupBoxEditarNome
            // 
            GroupBoxEditarNome.Controls.Add(TextBoxEditarNome);
            GroupBoxEditarNome.Location = new Point(3, 3);
            GroupBoxEditarNome.Name = "GroupBoxEditarNome";
            GroupBoxEditarNome.Size = new Size(376, 60);
            GroupBoxEditarNome.TabIndex = 6;
            GroupBoxEditarNome.TabStop = false;
            GroupBoxEditarNome.Text = "Nome";
            // 
            // TextBoxEditarNome
            // 
            TextBoxEditarNome.Location = new Point(6, 26);
            TextBoxEditarNome.Name = "TextBoxEditarNome";
            TextBoxEditarNome.ReadOnly = true;
            TextBoxEditarNome.Size = new Size(364, 27);
            TextBoxEditarNome.TabIndex = 0;
            // 
            // GroupBoxEditarCpf
            // 
            GroupBoxEditarCpf.Controls.Add(TextBoxEditarCpf);
            GroupBoxEditarCpf.Location = new Point(3, 69);
            GroupBoxEditarCpf.Name = "GroupBoxEditarCpf";
            GroupBoxEditarCpf.Size = new Size(376, 60);
            GroupBoxEditarCpf.TabIndex = 7;
            GroupBoxEditarCpf.TabStop = false;
            GroupBoxEditarCpf.Text = "Cpf";
            // 
            // TextBoxEditarCpf
            // 
            TextBoxEditarCpf.Location = new Point(6, 26);
            TextBoxEditarCpf.Name = "TextBoxEditarCpf";
            TextBoxEditarCpf.Size = new Size(364, 27);
            TextBoxEditarCpf.TabIndex = 0;
            // 
            // GroupBoxEditarTipoContrato
            // 
            GroupBoxEditarTipoContrato.Controls.Add(RadioBtnEditarAutonomo);
            GroupBoxEditarTipoContrato.Controls.Add(RadioBtnEditarPj);
            GroupBoxEditarTipoContrato.Controls.Add(RadioBtnEditarClt);
            GroupBoxEditarTipoContrato.Location = new Point(3, 333);
            GroupBoxEditarTipoContrato.Name = "GroupBoxEditarTipoContrato";
            GroupBoxEditarTipoContrato.Size = new Size(376, 60);
            GroupBoxEditarTipoContrato.TabIndex = 5;
            GroupBoxEditarTipoContrato.TabStop = false;
            GroupBoxEditarTipoContrato.Text = "Tipo de Contrato";
            // 
            // RadioBtnEditarAutonomo
            // 
            RadioBtnEditarAutonomo.AutoSize = true;
            RadioBtnEditarAutonomo.Dock = DockStyle.Left;
            RadioBtnEditarAutonomo.Location = new Point(98, 23);
            RadioBtnEditarAutonomo.Name = "RadioBtnEditarAutonomo";
            RadioBtnEditarAutonomo.Size = new Size(101, 34);
            RadioBtnEditarAutonomo.TabIndex = 4;
            RadioBtnEditarAutonomo.TabStop = true;
            RadioBtnEditarAutonomo.Text = "Autônomo";
            RadioBtnEditarAutonomo.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarPj
            // 
            RadioBtnEditarPj.AutoSize = true;
            RadioBtnEditarPj.Dock = DockStyle.Left;
            RadioBtnEditarPj.Location = new Point(56, 23);
            RadioBtnEditarPj.Name = "RadioBtnEditarPj";
            RadioBtnEditarPj.Size = new Size(42, 34);
            RadioBtnEditarPj.TabIndex = 3;
            RadioBtnEditarPj.TabStop = true;
            RadioBtnEditarPj.Text = "PJ";
            RadioBtnEditarPj.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarClt
            // 
            RadioBtnEditarClt.AutoSize = true;
            RadioBtnEditarClt.Dock = DockStyle.Left;
            RadioBtnEditarClt.Location = new Point(3, 23);
            RadioBtnEditarClt.Name = "RadioBtnEditarClt";
            RadioBtnEditarClt.Size = new Size(53, 34);
            RadioBtnEditarClt.TabIndex = 2;
            RadioBtnEditarClt.TabStop = true;
            RadioBtnEditarClt.Text = "CLT";
            RadioBtnEditarClt.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEditarSexo
            // 
            GroupBoxEditarSexo.Controls.Add(RadioBtnEditarFeminino);
            GroupBoxEditarSexo.Controls.Add(RadioBtnEditarMasculino);
            GroupBoxEditarSexo.Location = new Point(3, 267);
            GroupBoxEditarSexo.Name = "GroupBoxEditarSexo";
            GroupBoxEditarSexo.Size = new Size(376, 60);
            GroupBoxEditarSexo.TabIndex = 3;
            GroupBoxEditarSexo.TabStop = false;
            GroupBoxEditarSexo.Text = "Sexo";
            // 
            // RadioBtnEditarFeminino
            // 
            RadioBtnEditarFeminino.AutoSize = true;
            RadioBtnEditarFeminino.Dock = DockStyle.Left;
            RadioBtnEditarFeminino.Location = new Point(100, 23);
            RadioBtnEditarFeminino.Name = "RadioBtnEditarFeminino";
            RadioBtnEditarFeminino.Size = new Size(91, 34);
            RadioBtnEditarFeminino.TabIndex = 1;
            RadioBtnEditarFeminino.TabStop = true;
            RadioBtnEditarFeminino.Text = "Feminino";
            RadioBtnEditarFeminino.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarMasculino
            // 
            RadioBtnEditarMasculino.AutoSize = true;
            RadioBtnEditarMasculino.Dock = DockStyle.Left;
            RadioBtnEditarMasculino.Location = new Point(3, 23);
            RadioBtnEditarMasculino.Name = "RadioBtnEditarMasculino";
            RadioBtnEditarMasculino.Size = new Size(97, 34);
            RadioBtnEditarMasculino.TabIndex = 0;
            RadioBtnEditarMasculino.TabStop = true;
            RadioBtnEditarMasculino.Text = "Masculino";
            RadioBtnEditarMasculino.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEditarSalario
            // 
            GroupBoxEditarSalario.Controls.Add(TextBoxEditarSalario);
            GroupBoxEditarSalario.Location = new Point(3, 201);
            GroupBoxEditarSalario.Name = "GroupBoxEditarSalario";
            GroupBoxEditarSalario.Size = new Size(376, 60);
            GroupBoxEditarSalario.TabIndex = 9;
            GroupBoxEditarSalario.TabStop = false;
            GroupBoxEditarSalario.Text = "Salário";
            // 
            // TextBoxEditarSalario
            // 
            TextBoxEditarSalario.Location = new Point(6, 26);
            TextBoxEditarSalario.Name = "TextBoxEditarSalario";
            TextBoxEditarSalario.Size = new Size(364, 27);
            TextBoxEditarSalario.TabIndex = 2;
            // 
            // GroupBoxEditarEmail
            // 
            GroupBoxEditarEmail.Controls.Add(TextBoxEditarEmail);
            GroupBoxEditarEmail.Location = new Point(3, 135);
            GroupBoxEditarEmail.Name = "GroupBoxEditarEmail";
            GroupBoxEditarEmail.Size = new Size(376, 60);
            GroupBoxEditarEmail.TabIndex = 8;
            GroupBoxEditarEmail.TabStop = false;
            GroupBoxEditarEmail.Text = "Email";
            // 
            // TextBoxEditarEmail
            // 
            TextBoxEditarEmail.Location = new Point(6, 26);
            TextBoxEditarEmail.Name = "TextBoxEditarEmail";
            TextBoxEditarEmail.Size = new Size(364, 27);
            TextBoxEditarEmail.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(BtnEditarSalvar, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 399);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(376, 62);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // BtnEditarSalvar
            // 
            BtnEditarSalvar.Dock = DockStyle.Fill;
            BtnEditarSalvar.Location = new Point(78, 15);
            BtnEditarSalvar.Name = "BtnEditarSalvar";
            BtnEditarSalvar.Size = new Size(219, 31);
            BtnEditarSalvar.TabIndex = 0;
            BtnEditarSalvar.Text = "Salvar";
            BtnEditarSalvar.UseVisualStyleBackColor = true;
            BtnEditarSalvar.Click += BtnEditarSalvar_Click;
            // 
            // FormEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 523);
            Controls.Add(tableLayoutPanelMain);
            MinimumSize = new Size(450, 570);
            Name = "FormEditarFuncionario";
            Text = "Editar Funcionario";
            Load += FormEditarFuncionario_Load;
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            GroupBoxEditarNome.ResumeLayout(false);
            GroupBoxEditarNome.PerformLayout();
            GroupBoxEditarCpf.ResumeLayout(false);
            GroupBoxEditarCpf.PerformLayout();
            GroupBoxEditarTipoContrato.ResumeLayout(false);
            GroupBoxEditarTipoContrato.PerformLayout();
            GroupBoxEditarSexo.ResumeLayout(false);
            GroupBoxEditarSexo.PerformLayout();
            GroupBoxEditarSalario.ResumeLayout(false);
            GroupBoxEditarSalario.PerformLayout();
            GroupBoxEditarEmail.ResumeLayout(false);
            GroupBoxEditarEmail.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox GroupBoxEditarSexo;
        private GroupBox GroupBoxEditarTipoContrato;
        private GroupBox GroupBoxEditarNome;
        private RadioButton RadioBtnEditarFeminino;
        private RadioButton RadioBtnEditarMasculino;
        private RadioButton RadioBtnEditarClt;
        private TextBox TextBoxEditarNome;
        private GroupBox GroupBoxEditarCpf;
        private TextBox TextBoxEditarCpf;
        private GroupBox GroupBoxEditarEmail;
        private TextBox TextBoxEditarEmail;
        private GroupBox GroupBoxEditarSalario;
        private TextBox TextBoxEditarSalario;
        private RadioButton RadioBtnEditarAutonomo;
        private RadioButton RadioBtnEditarPj;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnEditarSalvar;
    }
}