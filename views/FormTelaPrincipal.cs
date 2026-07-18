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
        public SortableBindingList<Funcionario> tabelaFuncionarios = new();
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
            DgvFuncionarios.DataSource = tabelaFuncionarios;
            
            await AtualizarDataGrid();
        }

        public async Task AtualizarDataGrid(IEnumerable<Funcionario>? funcionarios = null)
        {
            try
            {
                if (funcionarios == null)
                {
                    funcionarios = await FuncionarioRepository.ObterTodos();
                }

                DgvFuncionarios.SuspendLayout();

                tabelaFuncionarios.Clear();

                foreach ( var funcionario in funcionarios )
                {
                    tabelaFuncionarios.Add(funcionario);
                }

                DgvFuncionarios.ClearSelection();
                DgvFuncionarios.ResumeLayout();
            }
            catch
            {
                MessageBox.Show(
                    "Ocorreu um erro ao atualizar os dados",
                    "Erro na conexão do banco de dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
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

        private async void TextBoxBuscarFuncionario_TextChanged(object sender, EventArgs e)
        {
            string? entry = TextBoxBuscarFuncionario.Text.ToLower();

            if (!string.IsNullOrEmpty(entry) && entry.ToLower().Contains("id:"))
            {
                try
                {
                    string entryFormatada = entry.Replace("id:", "").Replace(" ", "").Trim();
                    if (!string.IsNullOrEmpty(entryFormatada))
                    {
                        int id = int.Parse(entryFormatada);
                        var funcionarios = await FuncionarioRepository.PesquisarId(id);
                        await AtualizarDataGrid(funcionarios);
                    }
                    else
                    {
                        await AtualizarDataGrid();
                    }
                }
                catch (FormatException)
                {
                    return;
                }
            }
            else if (!string.IsNullOrEmpty(entry))
            {
                var funcionarios = await FuncionarioRepository.PesquisaGeral(entry);
                await AtualizarDataGrid(funcionarios);
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

        private async void BtnNovoFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario cadastrar = new FormCadastroFuncionario();
            cadastrar.FuncionarioCadastrado += SinalAtualizacao;
            cadastrar.ShowDialog();
        }

        private async Task EditarFuncionario()
        {
            if (DgvFuncionarios.CurrentRow != null)
            {
                Funcionario? funcionario = DgvFuncionarios.CurrentRow.DataBoundItem as Funcionario;

                if (funcionario != null)
                {
                    FormEditarFuncionario editor = new FormEditarFuncionario(funcionario);
                    editor.FuncionarioAtualizado += SinalAtualizacao;
                    editor.ShowDialog();
                }
            }
        }

        private async void DgvFuncionarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                await EditarFuncionario();
            }
            else
            {
                return;
            }
        }

        private async void BtnEditarFuncionario_Click(object sender, EventArgs e)
        {
            await EditarFuncionario();
        }

        private async void SinalAtualizacao(object? sender, EventArgs e)
        {
            await AtualizarDataGrid();
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
                        try
                        {
                            List<int>? listIds = [];

                            foreach (Funcionario func in funcionarios)
                            {
                                listIds.Add(func.Id);
                            }

                            await FuncionarioRepository.Remover(listIds);

                            MessageBox.Show(
                                "Operação concluida com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                            await AtualizarDataGrid();
                        }
                        catch
                        {
                            MessageBox.Show(
                                "Ocorreu um erro ao remover o(s) funcionário(s)",
                                "Erro na conexão do banco de dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                        }
                    }
                }
            }
        }
    }
}
