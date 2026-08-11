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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPageFuncionario = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            TextBoxEditarNome = new TextBox();
            groupBox2 = new GroupBox();
            MTextBoxEditarCpf = new MaskedTextBox();
            groupBox3 = new GroupBox();
            TextBoxEditarEmail = new TextBox();
            groupBox4 = new GroupBox();
            TextBoxEditarSenha = new TextBox();
            groupBox5 = new GroupBox();
            TextBoxEditarSalario = new TextBox();
            groupBox8 = new GroupBox();
            RadioBtnEditarFeminino = new RadioButton();
            RadioBtnEditarMasculino = new RadioButton();
            groupBox9 = new GroupBox();
            RadioBtnEditarAutonomo = new RadioButton();
            RadioBtnEditarPj = new RadioButton();
            RadioBtnEditarClt = new RadioButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            LabelEditarErro = new Label();
            tabPageDependentes = new TabPage();
            DgvDependentes = new DataGridView();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            DepenContextMenu = new ContextMenuStrip(components);
            EditarDepenToolStripMenuItem = new ToolStripMenuItem();
            ExcluirDepenToolStripMenuItem = new ToolStripMenuItem();
            DepenDgvContextMenuStrip = new ContextMenuStrip(components);
            NovoDependenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            AtualizarDgvToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageFuncionario.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabPageDependentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDependentes).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            DepenContextMenu.SuspendLayout();
            DepenDgvContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(tabControl1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(482, 653);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageFuncionario);
            tabControl1.Controls.Add(tabPageDependentes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(27, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(427, 614);
            tabControl1.TabIndex = 0;
            // 
            // tabPageFuncionario
            // 
            tabPageFuncionario.Controls.Add(tableLayoutPanel2);
            tabPageFuncionario.Location = new Point(4, 29);
            tabPageFuncionario.Name = "tabPageFuncionario";
            tabPageFuncionario.Padding = new Padding(3);
            tabPageFuncionario.Size = new Size(419, 581);
            tabPageFuncionario.TabIndex = 0;
            tabPageFuncionario.Text = "Funcionário";
            tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 4);
            tableLayoutPanel2.Controls.Add(groupBox8, 0, 5);
            tableLayoutPanel2.Controls.Add(groupBox9, 0, 6);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 8);
            tableLayoutPanel2.Controls.Add(LabelEditarErro, 0, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(413, 575);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextBoxEditarNome);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 54);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nome";
            // 
            // TextBoxEditarNome
            // 
            TextBoxEditarNome.Location = new Point(6, 21);
            TextBoxEditarNome.Name = "TextBoxEditarNome";
            TextBoxEditarNome.ReadOnly = true;
            TextBoxEditarNome.Size = new Size(305, 27);
            TextBoxEditarNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MTextBoxEditarCpf);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CPF";
            // 
            // MTextBoxEditarCpf
            // 
            MTextBoxEditarCpf.Location = new Point(6, 21);
            MTextBoxEditarCpf.Mask = "000\\.000\\.000\\-00";
            MTextBoxEditarCpf.Name = "MTextBoxEditarCpf";
            MTextBoxEditarCpf.Size = new Size(305, 27);
            MTextBoxEditarCpf.TabIndex = 0;
            MTextBoxEditarCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TextBoxEditarEmail);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(407, 54);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
            // 
            // TextBoxEditarEmail
            // 
            TextBoxEditarEmail.Location = new Point(6, 21);
            TextBoxEditarEmail.Name = "TextBoxEditarEmail";
            TextBoxEditarEmail.Size = new Size(305, 27);
            TextBoxEditarEmail.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TextBoxEditarSenha);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 183);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(407, 54);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Alterar Senha";
            // 
            // TextBoxEditarSenha
            // 
            TextBoxEditarSenha.Location = new Point(6, 21);
            TextBoxEditarSenha.Name = "TextBoxEditarSenha";
            TextBoxEditarSenha.Size = new Size(305, 27);
            TextBoxEditarSenha.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(TextBoxEditarSalario);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 243);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(407, 54);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Salário";
            // 
            // TextBoxEditarSalario
            // 
            TextBoxEditarSalario.BackColor = SystemColors.Window;
            TextBoxEditarSalario.Location = new Point(6, 21);
            TextBoxEditarSalario.Name = "TextBoxEditarSalario";
            TextBoxEditarSalario.ReadOnly = true;
            TextBoxEditarSalario.Size = new Size(305, 27);
            TextBoxEditarSalario.TabIndex = 0;
            TextBoxEditarSalario.Text = " ";
            TextBoxEditarSalario.KeyDown += TextBoxEditarSalario_KeyDown;
            TextBoxEditarSalario.KeyPress += TextBoxEditarSalario_KeyPress;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(RadioBtnEditarFeminino);
            groupBox8.Controls.Add(RadioBtnEditarMasculino);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.Location = new Point(3, 303);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(407, 54);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Sexo";
            // 
            // RadioBtnEditarFeminino
            // 
            RadioBtnEditarFeminino.AutoSize = true;
            RadioBtnEditarFeminino.Location = new Point(109, 24);
            RadioBtnEditarFeminino.Name = "RadioBtnEditarFeminino";
            RadioBtnEditarFeminino.Size = new Size(91, 24);
            RadioBtnEditarFeminino.TabIndex = 1;
            RadioBtnEditarFeminino.TabStop = true;
            RadioBtnEditarFeminino.Text = "Feminino";
            RadioBtnEditarFeminino.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarMasculino
            // 
            RadioBtnEditarMasculino.AutoSize = true;
            RadioBtnEditarMasculino.Location = new Point(6, 24);
            RadioBtnEditarMasculino.Name = "RadioBtnEditarMasculino";
            RadioBtnEditarMasculino.Size = new Size(97, 24);
            RadioBtnEditarMasculino.TabIndex = 0;
            RadioBtnEditarMasculino.TabStop = true;
            RadioBtnEditarMasculino.Text = "Masculino";
            RadioBtnEditarMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(RadioBtnEditarAutonomo);
            groupBox9.Controls.Add(RadioBtnEditarPj);
            groupBox9.Controls.Add(RadioBtnEditarClt);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Location = new Point(3, 363);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(407, 54);
            groupBox9.TabIndex = 6;
            groupBox9.TabStop = false;
            groupBox9.Text = "Tipo de Contrato";
            // 
            // RadioBtnEditarAutonomo
            // 
            RadioBtnEditarAutonomo.AutoSize = true;
            RadioBtnEditarAutonomo.Location = new Point(113, 24);
            RadioBtnEditarAutonomo.Name = "RadioBtnEditarAutonomo";
            RadioBtnEditarAutonomo.Size = new Size(101, 24);
            RadioBtnEditarAutonomo.TabIndex = 2;
            RadioBtnEditarAutonomo.TabStop = true;
            RadioBtnEditarAutonomo.Text = "Autônomo";
            RadioBtnEditarAutonomo.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarPj
            // 
            RadioBtnEditarPj.AutoSize = true;
            RadioBtnEditarPj.Location = new Point(65, 24);
            RadioBtnEditarPj.Name = "RadioBtnEditarPj";
            RadioBtnEditarPj.Size = new Size(42, 24);
            RadioBtnEditarPj.TabIndex = 1;
            RadioBtnEditarPj.TabStop = true;
            RadioBtnEditarPj.Text = "PJ";
            RadioBtnEditarPj.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarClt
            // 
            RadioBtnEditarClt.AutoSize = true;
            RadioBtnEditarClt.Location = new Point(6, 24);
            RadioBtnEditarClt.Name = "RadioBtnEditarClt";
            RadioBtnEditarClt.Size = new Size(53, 24);
            RadioBtnEditarClt.TabIndex = 0;
            RadioBtnEditarClt.TabStop = true;
            RadioBtnEditarClt.Text = "CLT";
            RadioBtnEditarClt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Controls.Add(button1, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 518);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.Size = new Size(407, 54);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(43, 11);
            button1.Name = "button1";
            button1.Size = new Size(319, 31);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnEditarSalvar_Click;
            // 
            // LabelEditarErro
            // 
            LabelEditarErro.AutoSize = true;
            LabelEditarErro.ForeColor = Color.Red;
            LabelEditarErro.Location = new Point(3, 420);
            LabelEditarErro.Name = "LabelEditarErro";
            LabelEditarErro.Size = new Size(0, 20);
            LabelEditarErro.TabIndex = 8;
            // 
            // tabPageDependentes
            // 
            tabPageDependentes.Controls.Add(DgvDependentes);
            tabPageDependentes.Location = new Point(4, 29);
            tabPageDependentes.Name = "tabPageDependentes";
            tabPageDependentes.Padding = new Padding(3);
            tabPageDependentes.Size = new Size(419, 581);
            tabPageDependentes.TabIndex = 1;
            tabPageDependentes.Text = "Dependentes";
            tabPageDependentes.UseVisualStyleBackColor = true;
            // 
            // DgvDependentes
            // 
            DgvDependentes.BackgroundColor = SystemColors.ControlLight;
            DgvDependentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDependentes.ContextMenuStrip = DepenDgvContextMenuStrip;
            DgvDependentes.Dock = DockStyle.Fill;
            DgvDependentes.Location = new Point(3, 3);
            DgvDependentes.Name = "DgvDependentes";
            DgvDependentes.RowHeadersWidth = 51;
            DgvDependentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDependentes.Size = new Size(413, 575);
            DgvDependentes.TabIndex = 0;
            DgvDependentes.CellContextMenuStripNeeded += DgvDependentes_CellContextMenuStripNeeded;
            DgvDependentes.MouseDown += DgvDependentes_MouseDown;
            // 
            // groupBox6
            // 
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(3, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(194, 54);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Nome";
            // 
            // groupBox7
            // 
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(3, 63);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(194, 54);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "CPF";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox6, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // DepenContextMenu
            // 
            DepenContextMenu.ImageScalingSize = new Size(20, 20);
            DepenContextMenu.Items.AddRange(new ToolStripItem[] { EditarDepenToolStripMenuItem, ExcluirDepenToolStripMenuItem });
            DepenContextMenu.Name = "DepenContextMenu";
            DepenContextMenu.Size = new Size(122, 52);
            // 
            // EditarDepenToolStripMenuItem
            // 
            EditarDepenToolStripMenuItem.Name = "EditarDepenToolStripMenuItem";
            EditarDepenToolStripMenuItem.Size = new Size(121, 24);
            EditarDepenToolStripMenuItem.Text = "Editar";
            // 
            // ExcluirDepenToolStripMenuItem
            // 
            ExcluirDepenToolStripMenuItem.Name = "ExcluirDepenToolStripMenuItem";
            ExcluirDepenToolStripMenuItem.Size = new Size(121, 24);
            ExcluirDepenToolStripMenuItem.Text = "Excluir";
            // 
            // DepenDgvContextMenuStrip
            // 
            DepenDgvContextMenuStrip.ImageScalingSize = new Size(20, 20);
            DepenDgvContextMenuStrip.Items.AddRange(new ToolStripItem[] { NovoDependenteToolStripMenuItem, toolStripSeparator1, AtualizarDgvToolStripMenuItem });
            DepenDgvContextMenuStrip.Name = "DepenDgvContextMenuStrip";
            DepenDgvContextMenuStrip.Size = new Size(138, 58);
            // 
            // NovoDependenteToolStripMenuItem
            // 
            NovoDependenteToolStripMenuItem.Name = "NovoDependenteToolStripMenuItem";
            NovoDependenteToolStripMenuItem.Size = new Size(137, 24);
            NovoDependenteToolStripMenuItem.Text = "Novo";
            NovoDependenteToolStripMenuItem.Click += NovoDependenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(134, 6);
            // 
            // AtualizarDgvToolStripMenuItem
            // 
            AtualizarDgvToolStripMenuItem.Name = "AtualizarDgvToolStripMenuItem";
            AtualizarDgvToolStripMenuItem.Size = new Size(137, 24);
            AtualizarDgvToolStripMenuItem.Text = "Atualizar";
            // 
            // FormEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 653);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(500, 700);
            Name = "FormEditarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Funcionario";
            Load += FormEditarFuncionario_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageFuncionario.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tabPageDependentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDependentes).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            DepenContextMenu.ResumeLayout(false);
            DepenDgvContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPageFuncionario;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TabPage tabPageDependentes;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox TextBoxEditarNome;
        private TextBox TextBoxEditarEmail;
        private TextBox TextBoxEditarSenha;
        private TextBox TextBoxEditarSalario;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private RadioButton RadioBtnEditarFeminino;
        private RadioButton RadioBtnEditarMasculino;
        private RadioButton RadioBtnEditarAutonomo;
        private RadioButton RadioBtnEditarPj;
        private RadioButton RadioBtnEditarClt;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private MaskedTextBox MTextBoxEditarCpf;
        private Label LabelEditarErro;
        private DataGridView DgvDependentes;
        private ContextMenuStrip DepenContextMenu;
        private ContextMenuStrip DepenDgvContextMenuStrip;
        private ToolStripMenuItem adicionarDependenteToolStripMenuItem;
        private ToolStripMenuItem AtualizarDgvToolStripMenuItem;
        private ToolStripMenuItem NovoDependenteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem EditarDepenToolStripMenuItem;
        private ToolStripMenuItem ExcluirDepenToolStripMenuItem;
    }
}