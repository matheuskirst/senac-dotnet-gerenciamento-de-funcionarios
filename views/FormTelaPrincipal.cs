using GerenciamentoDeFuncionarios.banco.repositories;
using GerenciamentoDeFuncionarios.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.views
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();

            typeof(DataGridView).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(DgvFuncionarios, true);
        }

        private async void FormTelaPrincipal_Load(object? sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        public async Task AtualizarDataGrid()
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            DgvFuncionarios.DataSource = new SortableBindingList<Funcionario>(funcionarios.ToList());
        }

        private List<Funcionario> ExtrairFuncionarios()
        {
            List<Funcionario>? funcionarios = [];
            foreach (DataGridViewRow row in DgvFuncionarios.SelectedRows)
            {
                Funcionario? func = row.DataBoundItem as Funcionario;
                if (func != null)
                {
                    funcionarios.Add(func);
                }
            }
            return funcionarios;
        }

        private void DgvFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvFuncionarios.Columns[e.ColumnIndex].Name == "Cpf" && e.Value != null)
            {
                string? cpf = e.Value?.ToString();

                if (cpf != null && cpf.Length == 11)
                {
                    e.Value = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                    e.FormattingApplied = true;
                }
            }
            foreach (DataGridViewColumn col in DgvFuncionarios.Columns)
            {
                if (col.ValueType == typeof(DateTime) || col.ValueType == typeof(DateTime?))
                {
                    col.DefaultCellStyle.Format = "yyyy/MM/dd - HH:mm:ss";
                }
            }
        }

        private async void TextBoxBuscarFuncionario_TextChanged(object sender, EventArgs e)
        {
            string? prompt = TextBoxBuscarFuncionario.Text.ToLower();

            if (!string.IsNullOrEmpty(prompt))
            {
                var funcionarios = await FuncionarioRepository.PesquisarFuncionarios(prompt);

                DgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
            }
            else
            {
                await AtualizarDataGrid();
            }
        }

        private async void BtnAtualizarDgv_Click(object sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        //private async void TextBoxBuscarFuncionario_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        string? prompt = TextBoxBuscarFuncionario.Text.ToLower();

        //        if (!string.IsNullOrEmpty(prompt))
        //        {
        //            var funcionarios = await FuncionarioRepository.PesquisarFuncionarios(prompt);

        //            DgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
        //        }
        //        else
        //        {
        //            AtualizarDataGrid();
        //        }
        //    }
        //}

        private async void BtnNovoFuncionario_Click(object sender, EventArgs e)
        {
            new FormCadastroFuncionario().ShowDialog();
            await AtualizarDataGrid();
        }

        private async void BtnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (DgvFuncionarios.CurrentRow != null)
            {
                Funcionario? funcionario = DgvFuncionarios.CurrentRow.DataBoundItem as Funcionario;

                if (funcionario != null)
                {
                    new FormEditarFuncionario(funcionario).ShowDialog();

                    await AtualizarDataGrid();
                }
            }
        }

        private async void BtnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            int quantidadeSelecionado = DgvFuncionarios.SelectedRows.Count;

            if (quantidadeSelecionado > 0)
            {
                List<Funcionario>? funcionarios = ExtrairFuncionarios();

                if (funcionarios.Count() > 0)
                {
                    DialogResult? removerFuncionario;

                    if (quantidadeSelecionado == 1)
                    {
                        removerFuncionario = MessageBox.Show(
                            $"Essa ação irá remover o funcionário \"{funcionarios.First().Nome}\" (Id: {funcionarios.First().Id})\nVocê tem certeza?",
                            "Remover funcionário",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2
                            );
                    }
                    else
                    {
                        removerFuncionario = MessageBox.Show(
                            $"Essa ação irá remover múltiplos funcionários\nVocê tem certeza?",
                            "Remover funcionários",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2
                            );
                    }

                    if (removerFuncionario == DialogResult.Yes)
                    {
                        foreach (Funcionario func in funcionarios)
                        {
                            await FuncionarioRepository.Remover(func);
                        }

                        MessageBox.Show(
                            "Operação concluida com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        await AtualizarDataGrid();
                    }
                }
            }
        }
    }
}
