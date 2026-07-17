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
            MTextBoxEditarCpf = new MaskedTextBox();
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
            LabelEditarErro = new Label();
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
            tableLayoutPanelMain.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelMain.Size = new Size(380, 481);
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(LabelEditarErro, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(22, 26);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5032835F));
            tableLayoutPanel1.Size = new Size(336, 428);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // GroupBoxEditarNome
            // 
            GroupBoxEditarNome.Controls.Add(TextBoxEditarNome);
            GroupBoxEditarNome.Dock = DockStyle.Fill;
            GroupBoxEditarNome.Location = new Point(3, 2);
            GroupBoxEditarNome.Margin = new Padding(3, 2, 3, 2);
            GroupBoxEditarNome.Name = "GroupBoxEditarNome";
            GroupBoxEditarNome.Padding = new Padding(3, 2, 3, 2);
            GroupBoxEditarNome.Size = new Size(330, 49);
            GroupBoxEditarNome.TabIndex = 6;
            GroupBoxEditarNome.TabStop = false;
            GroupBoxEditarNome.Text = "Nome";
            // 
            // TextBoxEditarNome
            // 
            TextBoxEditarNome.BackColor = SystemColors.Window;
            TextBoxEditarNome.Location = new Point(5, 20);
            TextBoxEditarNome.Margin = new Padding(3, 2, 3, 2);
            TextBoxEditarNome.Name = "TextBoxEditarNome";
            TextBoxEditarNome.ReadOnly = true;
            TextBoxEditarNome.Size = new Size(319, 23);
            TextBoxEditarNome.TabIndex = 0;
            // 
            // GroupBoxEditarCpf
            // 
            GroupBoxEditarCpf.Controls.Add(MTextBoxEditarCpf);
            GroupBoxEditarCpf.Dock = DockStyle.Fill;
            GroupBoxEditarCpf.Location = new Point(3, 55);
            GroupBoxEditarCpf.Margin = new Padding(3, 2, 3, 2);
            GroupBoxEditarCpf.Name = "GroupBoxEditarCpf";
            GroupBoxEditarCpf.Padding = new Padding(3, 2, 3, 2);
            GroupBoxEditarCpf.Size = new Size(330, 49);
            GroupBoxEditarCpf.TabIndex = 7;
            GroupBoxEditarCpf.TabStop = false;
            GroupBoxEditarCpf.Text = "Cpf";
            // 
            // MTextBoxEditarCpf
            // 
            MTextBoxEditarCpf.Location = new Point(5, 20);
            MTextBoxEditarCpf.Margin = new Padding(3, 2, 3, 2);
            MTextBoxEditarCpf.Mask = "000\\.000\\.000\\-00";
            MTextBoxEditarCpf.Name = "MTextBoxEditarCpf";
            MTextBoxEditarCpf.Size = new Size(319, 23);
            MTextBoxEditarCpf.TabIndex = 0;
            // 
            // GroupBoxEditarTipoContrato
            // 
            GroupBoxEditarTipoContrato.Controls.Add(RadioBtnEditarAutonomo);
            GroupBoxEditarTipoContrato.Controls.Add(RadioBtnEditarPj);
            GroupBoxEditarTipoContrato.Controls.Add(RadioBtnEditarClt);
            GroupBoxEditarTipoContrato.Dock = DockStyle.Fill;
            GroupBoxEditarTipoContrato.Location = new Point(3, 267);
            GroupBoxEditarTipoContrato.Margin = new Padding(3, 2, 3, 2);
            GroupBoxEditarTipoContrato.Name = "GroupBoxEditarTipoContrato";
            GroupBoxEditarTipoContrato.Padding = new Padding(3, 2, 3, 2);
            GroupBoxEditarTipoContrato.Size = new Size(330, 49);
            GroupBoxEditarTipoContrato.TabIndex = 5;
            GroupBoxEditarTipoContrato.TabStop = false;
            GroupBoxEditarTipoContrato.Text = "Tipo de Contrato";
            // 
            // RadioBtnEditarAutonomo
            // 
            RadioBtnEditarAutonomo.AutoSize = true;
            RadioBtnEditarAutonomo.Dock = DockStyle.Left;
            RadioBtnEditarAutonomo.Location = new Point(83, 18);
            RadioBtnEditarAutonomo.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarAutonomo.Name = "RadioBtnEditarAutonomo";
            RadioBtnEditarAutonomo.Size = new Size(83, 29);
            RadioBtnEditarAutonomo.TabIndex = 4;
            RadioBtnEditarAutonomo.TabStop = true;
            RadioBtnEditarAutonomo.Text = "Autônomo";
            RadioBtnEditarAutonomo.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarPj
            // 
            RadioBtnEditarPj.AutoSize = true;
            RadioBtnEditarPj.Dock = DockStyle.Left;
            RadioBtnEditarPj.Location = new Point(48, 18);
            RadioBtnEditarPj.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarPj.Name = "RadioBtnEditarPj";
            RadioBtnEditarPj.Size = new Size(35, 29);
            RadioBtnEditarPj.TabIndex = 3;
            RadioBtnEditarPj.TabStop = true;
            RadioBtnEditarPj.Text = "PJ";
            RadioBtnEditarPj.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarClt
            // 
            RadioBtnEditarClt.AutoSize = true;
            RadioBtnEditarClt.Dock = DockStyle.Left;
            RadioBtnEditarClt.Location = new Point(3, 18);
            RadioBtnEditarClt.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarClt.Name = "RadioBtnEditarClt";
            RadioBtnEditarClt.Size = new Size(45, 29);
            RadioBtnEditarClt.TabIndex = 2;
            RadioBtnEditarClt.TabStop = true;
            RadioBtnEditarClt.Text = "CLT";
            RadioBtnEditarClt.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEditarSexo
            // 
            GroupBoxEditarSexo.Controls.Add(RadioBtnEditarFeminino);
            GroupBoxEditarSexo.Controls.Add(RadioBtnEditarMasculino);
            GroupBoxEditarSexo.Dock = DockStyle.Fill;
            GroupBoxEditarSexo.Location = new Point(3, 214);
            GroupBoxEditarSexo.Margin = new Padding(3, 2, 3, 2);
            GroupBoxEditarSexo.Name = "GroupBoxEditarSexo";
            GroupBoxEditarSexo.Padding = new Padding(3, 2, 3, 2);
            GroupBoxEditarSexo.Size = new Size(330, 49);
            GroupBoxEditarSexo.TabIndex = 3;
            GroupBoxEditarSexo.TabStop = false;
            GroupBoxEditarSexo.Text = "Sexo";
            // 
            // RadioBtnEditarFeminino
            // 
            RadioBtnEditarFeminino.AutoSize = true;
            RadioBtnEditarFeminino.Dock = DockStyle.Left;
            RadioBtnEditarFeminino.Location = new Point(83, 18);
            RadioBtnEditarFeminino.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarFeminino.Name = "RadioBtnEditarFeminino";
            RadioBtnEditarFeminino.Size = new Size(75, 29);
            RadioBtnEditarFeminino.TabIndex = 1;
            RadioBtnEditarFeminino.TabStop = true;
            RadioBtnEditarFeminino.Text = "Feminino";
            RadioBtnEditarFeminino.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarMasculino
            // 
            RadioBtnEditarMasculino.AutoSize = true;
            RadioBtnEditarMasculino.Dock = DockStyle.Left;
            RadioBtnEditarMasculino.Location = new Point(3, 18);
            RadioBtnEditarMasculino.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarMasculino.Name = "RadioBtnEditarMasculino";
            RadioBtnEditarMasculino.Size = new Size(80, 29);
            RadioBtnEditarMasculino.TabIndex = 0;
            RadioBtnEditarMasculino.TabStop = true;
            RadioBtnEditarMasculino.Text = "Masculino";
            RadioBtnEditarMasculino.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEditarSalario
            // 
            GroupBoxEditarSalario.Controls.Add(TextBoxEditarSalario);
            GroupBoxEditarSalario.Dock = DockStyle.Fill;
            GroupBoxEditarSalario.Location = new Point(3, 161);
            GroupBoxEditarSalario.Margin = new Padding(3, 2, 3, 2);
            GroupBoxEditarSalario.Name = "GroupBoxEditarSalario";
            GroupBoxEditarSalario.Padding = new Padding(3, 2, 3, 2);
            GroupBoxEditarSalario.Size = new Size(330, 49);
            GroupBoxEditarSalario.TabIndex = 9;
            GroupBoxEditarSalario.TabStop = false;
            GroupBoxEditarSalario.Text = "Salário";
            // 
            // TextBoxEditarSalario
            // 
            TextBoxEditarSalario.BackColor = SystemColors.Window;
            TextBoxEditarSalario.Location = new Point(5, 20);
            TextBoxEditarSalario.Margin = new Padding(3, 2, 3, 2);
            TextBoxEditarSalario.Name = "TextBoxEditarSalario";
            TextBoxEditarSalario.ReadOnly = true;
            TextBoxEditarSalario.Size = new Size(319, 23);
            TextBoxEditarSalario.TabIndex = 2;
            TextBoxEditarSalario.Text = "R$ 0,00";
            TextBoxEditarSalario.KeyDown += TextBoxEditarSalario_KeyDown;
            TextBoxEditarSalario.KeyPress += TextBoxEditarSalario_KeyPress;
            // 
            // GroupBoxEditarEmail
            // 
            GroupBoxEditarEmail.Controls.Add(TextBoxEditarEmail);
            GroupBoxEditarEmail.Dock = DockStyle.Fill;
            GroupBoxEditarEmail.Location = new Point(3, 108);
            GroupBoxEditarEmail.Margin = new Padding(3, 2, 3, 2);
            GroupBoxEditarEmail.Name = "GroupBoxEditarEmail";
            GroupBoxEditarEmail.Padding = new Padding(3, 2, 3, 2);
            GroupBoxEditarEmail.Size = new Size(330, 49);
            GroupBoxEditarEmail.TabIndex = 8;
            GroupBoxEditarEmail.TabStop = false;
            GroupBoxEditarEmail.Text = "Email";
            // 
            // TextBoxEditarEmail
            // 
            TextBoxEditarEmail.Location = new Point(5, 20);
            TextBoxEditarEmail.Margin = new Padding(3, 2, 3, 2);
            TextBoxEditarEmail.Name = "TextBoxEditarEmail";
            TextBoxEditarEmail.Size = new Size(319, 23);
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
            tableLayoutPanel2.Location = new Point(3, 373);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(330, 53);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // BtnEditarSalvar
            // 
            BtnEditarSalvar.Dock = DockStyle.Fill;
            BtnEditarSalvar.Location = new Point(69, 7);
            BtnEditarSalvar.Margin = new Padding(3, 2, 3, 2);
            BtnEditarSalvar.Name = "BtnEditarSalvar";
            BtnEditarSalvar.Size = new Size(192, 38);
            BtnEditarSalvar.TabIndex = 0;
            BtnEditarSalvar.Text = "Salvar";
            BtnEditarSalvar.UseVisualStyleBackColor = true;
            BtnEditarSalvar.Click += BtnEditarSalvar_Click;
            // 
            // LabelEditarErro
            // 
            LabelEditarErro.AutoSize = true;
            LabelEditarErro.BackColor = SystemColors.Control;
            LabelEditarErro.Dock = DockStyle.Left;
            LabelEditarErro.ForeColor = Color.Red;
            LabelEditarErro.Location = new Point(3, 318);
            LabelEditarErro.Name = "LabelEditarErro";
            LabelEditarErro.Size = new Size(0, 53);
            LabelEditarErro.TabIndex = 11;
            // 
            // FormEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 481);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(396, 520);
            MinimumSize = new Size(396, 520);
            Name = "FormEditarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Funcionario";
            Load += FormEditarFuncionario_Load;
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private GroupBox GroupBoxEditarEmail;
        private TextBox TextBoxEditarEmail;
        private GroupBox GroupBoxEditarSalario;
        private TextBox TextBoxEditarSalario;
        private RadioButton RadioBtnEditarAutonomo;
        private RadioButton RadioBtnEditarPj;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnEditarSalvar;
        private MaskedTextBox MTextBoxEditarCpf;
        private Label LabelEditarErro;
    }
}