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
            DepenDgvContextMenuStrip = new ContextMenuStrip(components);
            NovoDependenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            AtualizarDgvToolStripMenuItem = new ToolStripMenuItem();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            DepenContextMenu = new ContextMenuStrip(components);
            EditarDepenToolStripMenuItem = new ToolStripMenuItem();
            ExcluirDepenToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            DepenDgvContextMenuStrip.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            DepenContextMenu.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
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
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(424, 496);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageFuncionario);
            tabControl1.Controls.Add(tabPageDependentes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(24, 2);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(375, 467);
            tabControl1.TabIndex = 0;
            // 
            // tabPageFuncionario
            // 
            tabPageFuncionario.Controls.Add(tableLayoutPanel2);
            tabPageFuncionario.Location = new Point(4, 24);
            tabPageFuncionario.Margin = new Padding(3, 2, 3, 2);
            tabPageFuncionario.Name = "tabPageFuncionario";
            tabPageFuncionario.Padding = new Padding(3, 2, 3, 2);
            tabPageFuncionario.Size = new Size(367, 439);
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
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.Size = new Size(361, 435);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextBoxEditarNome);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(355, 41);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nome";
            // 
            // TextBoxEditarNome
            // 
            TextBoxEditarNome.Location = new Point(5, 16);
            TextBoxEditarNome.Margin = new Padding(3, 2, 3, 2);
            TextBoxEditarNome.Name = "TextBoxEditarNome";
            TextBoxEditarNome.ReadOnly = true;
            TextBoxEditarNome.Size = new Size(267, 23);
            TextBoxEditarNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MTextBoxEditarCpf);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 47);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(355, 41);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CPF";
            // 
            // MTextBoxEditarCpf
            // 
            MTextBoxEditarCpf.Location = new Point(5, 16);
            MTextBoxEditarCpf.Margin = new Padding(3, 2, 3, 2);
            MTextBoxEditarCpf.Mask = "000\\.000\\.000\\-00";
            MTextBoxEditarCpf.Name = "MTextBoxEditarCpf";
            MTextBoxEditarCpf.Size = new Size(267, 23);
            MTextBoxEditarCpf.TabIndex = 0;
            MTextBoxEditarCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TextBoxEditarEmail);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 92);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(355, 41);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
            // 
            // TextBoxEditarEmail
            // 
            TextBoxEditarEmail.Location = new Point(5, 16);
            TextBoxEditarEmail.Margin = new Padding(3, 2, 3, 2);
            TextBoxEditarEmail.Name = "TextBoxEditarEmail";
            TextBoxEditarEmail.Size = new Size(267, 23);
            TextBoxEditarEmail.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TextBoxEditarSenha);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 137);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(355, 41);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Alterar Senha";
            // 
            // TextBoxEditarSenha
            // 
            TextBoxEditarSenha.Location = new Point(5, 16);
            TextBoxEditarSenha.Margin = new Padding(3, 2, 3, 2);
            TextBoxEditarSenha.Name = "TextBoxEditarSenha";
            TextBoxEditarSenha.Size = new Size(267, 23);
            TextBoxEditarSenha.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(TextBoxEditarSalario);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 182);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(355, 41);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Salário";
            // 
            // TextBoxEditarSalario
            // 
            TextBoxEditarSalario.BackColor = SystemColors.Window;
            TextBoxEditarSalario.Location = new Point(5, 16);
            TextBoxEditarSalario.Margin = new Padding(3, 2, 3, 2);
            TextBoxEditarSalario.Name = "TextBoxEditarSalario";
            TextBoxEditarSalario.ReadOnly = true;
            TextBoxEditarSalario.Size = new Size(267, 23);
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
            groupBox8.Location = new Point(3, 227);
            groupBox8.Margin = new Padding(3, 2, 3, 2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 2, 3, 2);
            groupBox8.Size = new Size(355, 41);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Sexo";
            // 
            // RadioBtnEditarFeminino
            // 
            RadioBtnEditarFeminino.AutoSize = true;
            RadioBtnEditarFeminino.Location = new Point(95, 18);
            RadioBtnEditarFeminino.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarFeminino.Name = "RadioBtnEditarFeminino";
            RadioBtnEditarFeminino.Size = new Size(75, 19);
            RadioBtnEditarFeminino.TabIndex = 1;
            RadioBtnEditarFeminino.TabStop = true;
            RadioBtnEditarFeminino.Text = "Feminino";
            RadioBtnEditarFeminino.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarMasculino
            // 
            RadioBtnEditarMasculino.AutoSize = true;
            RadioBtnEditarMasculino.Location = new Point(5, 18);
            RadioBtnEditarMasculino.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarMasculino.Name = "RadioBtnEditarMasculino";
            RadioBtnEditarMasculino.Size = new Size(80, 19);
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
            groupBox9.Location = new Point(3, 272);
            groupBox9.Margin = new Padding(3, 2, 3, 2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 2, 3, 2);
            groupBox9.Size = new Size(355, 41);
            groupBox9.TabIndex = 6;
            groupBox9.TabStop = false;
            groupBox9.Text = "Tipo de Contrato";
            // 
            // RadioBtnEditarAutonomo
            // 
            RadioBtnEditarAutonomo.AutoSize = true;
            RadioBtnEditarAutonomo.Location = new Point(99, 18);
            RadioBtnEditarAutonomo.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarAutonomo.Name = "RadioBtnEditarAutonomo";
            RadioBtnEditarAutonomo.Size = new Size(83, 19);
            RadioBtnEditarAutonomo.TabIndex = 2;
            RadioBtnEditarAutonomo.TabStop = true;
            RadioBtnEditarAutonomo.Text = "Autônomo";
            RadioBtnEditarAutonomo.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarPj
            // 
            RadioBtnEditarPj.AutoSize = true;
            RadioBtnEditarPj.Location = new Point(57, 18);
            RadioBtnEditarPj.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarPj.Name = "RadioBtnEditarPj";
            RadioBtnEditarPj.Size = new Size(35, 19);
            RadioBtnEditarPj.TabIndex = 1;
            RadioBtnEditarPj.TabStop = true;
            RadioBtnEditarPj.Text = "PJ";
            RadioBtnEditarPj.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEditarClt
            // 
            RadioBtnEditarClt.AutoSize = true;
            RadioBtnEditarClt.Location = new Point(5, 18);
            RadioBtnEditarClt.Margin = new Padding(3, 2, 3, 2);
            RadioBtnEditarClt.Name = "RadioBtnEditarClt";
            RadioBtnEditarClt.Size = new Size(45, 19);
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
            tableLayoutPanel4.Location = new Point(3, 392);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.Size = new Size(355, 41);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(38, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(278, 24);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnEditarSalvar_Click;
            // 
            // LabelEditarErro
            // 
            LabelEditarErro.AutoSize = true;
            LabelEditarErro.ForeColor = Color.Red;
            LabelEditarErro.Location = new Point(3, 315);
            LabelEditarErro.Name = "LabelEditarErro";
            LabelEditarErro.Size = new Size(0, 15);
            LabelEditarErro.TabIndex = 8;
            // 
            // tabPageDependentes
            // 
            tabPageDependentes.Controls.Add(tableLayoutPanel5);
            tabPageDependentes.Location = new Point(4, 24);
            tabPageDependentes.Margin = new Padding(3, 2, 3, 2);
            tabPageDependentes.Name = "tabPageDependentes";
            tabPageDependentes.Padding = new Padding(3, 2, 3, 2);
            tabPageDependentes.Size = new Size(367, 439);
            tabPageDependentes.TabIndex = 1;
            tabPageDependentes.Text = "Dependentes";
            tabPageDependentes.UseVisualStyleBackColor = true;
            // 
            // DgvDependentes
            // 
            DgvDependentes.AllowUserToOrderColumns = true;
            DgvDependentes.BackgroundColor = SystemColors.ControlLight;
            DgvDependentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDependentes.ContextMenuStrip = DepenDgvContextMenuStrip;
            DgvDependentes.Dock = DockStyle.Fill;
            DgvDependentes.Location = new Point(3, 2);
            DgvDependentes.Margin = new Padding(3, 2, 3, 2);
            DgvDependentes.Name = "DgvDependentes";
            DgvDependentes.ReadOnly = true;
            DgvDependentes.RowHeadersWidth = 51;
            DgvDependentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDependentes.Size = new Size(355, 371);
            DgvDependentes.TabIndex = 0;
            DgvDependentes.CellContextMenuStripNeeded += DgvDependentes_CellContextMenuStripNeeded;
            DgvDependentes.MouseDown += DgvDependentes_MouseDown;
            // 
            // DepenDgvContextMenuStrip
            // 
            DepenDgvContextMenuStrip.ImageScalingSize = new Size(20, 20);
            DepenDgvContextMenuStrip.Items.AddRange(new ToolStripItem[] { NovoDependenteToolStripMenuItem, toolStripSeparator1, AtualizarDgvToolStripMenuItem });
            DepenDgvContextMenuStrip.Name = "DepenDgvContextMenuStrip";
            DepenDgvContextMenuStrip.Size = new Size(121, 54);
            // 
            // NovoDependenteToolStripMenuItem
            // 
            NovoDependenteToolStripMenuItem.Name = "NovoDependenteToolStripMenuItem";
            NovoDependenteToolStripMenuItem.Size = new Size(120, 22);
            NovoDependenteToolStripMenuItem.Text = "Novo";
            NovoDependenteToolStripMenuItem.Click += NovoDependenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(117, 6);
            // 
            // AtualizarDgvToolStripMenuItem
            // 
            AtualizarDgvToolStripMenuItem.Name = "AtualizarDgvToolStripMenuItem";
            AtualizarDgvToolStripMenuItem.Size = new Size(120, 22);
            AtualizarDgvToolStripMenuItem.Text = "Atualizar";
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
            DepenContextMenu.Size = new Size(109, 48);
            // 
            // EditarDepenToolStripMenuItem
            // 
            EditarDepenToolStripMenuItem.Name = "EditarDepenToolStripMenuItem";
            EditarDepenToolStripMenuItem.Size = new Size(108, 22);
            EditarDepenToolStripMenuItem.Text = "Editar";
            // 
            // ExcluirDepenToolStripMenuItem
            // 
            ExcluirDepenToolStripMenuItem.Name = "ExcluirDepenToolStripMenuItem";
            ExcluirDepenToolStripMenuItem.Size = new Size(108, 22);
            ExcluirDepenToolStripMenuItem.Text = "Excluir";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(DgvDependentes, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.Size = new Size(361, 435);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.Controls.Add(button2, 0, 1);
            tableLayoutPanel6.Controls.Add(button3, 3, 1);
            tableLayoutPanel6.Controls.Add(button4, 2, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 378);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.Size = new Size(355, 54);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 17);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 0;
            button2.Text = "Novo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(258, 17);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 1;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(158, 17);
            button4.Name = "button4";
            button4.Size = new Size(94, 34);
            button4.TabIndex = 2;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 496);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(440, 535);
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
            DepenDgvContextMenuStrip.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            DepenContextMenu.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}