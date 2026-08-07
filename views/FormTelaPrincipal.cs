using GerenciamentoDeFuncionarios.banco.repositories;
using GerenciamentoDeFuncionarios.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.views
{
    public partial class FormTelaPrincipal : Form
    {
        private Usuario? _usuario;

        private TiposDeContrato? filtroContrato = null;

        public SortableBindingList<Funcionario> tabelaFuncionarios = new();
        public FormTelaPrincipal(Usuario usuario)
        {
            InitializeComponent();

            _usuario = usuario;
            typeof(DataGridView).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(DgvFuncionarios, true);
        }

        private async void FormTelaPrincipal_Load(object? sender, EventArgs e)
        {
            await CarregarContratos();

            DgvFuncionarios.DataSource = tabelaFuncionarios;
            DgvFuncionarios.Columns["Senha"].Visible = false;
            DgvFuncionarios.Columns["TipoDeContratoId"].Visible = false;
            ContratoComboBox.Items.Add("Todos");

            foreach (TiposDeContrato contrato in Enum.GetValues(typeof(TiposDeContrato)))
            {
                ContratoComboBox.Items.Add(contrato.ToString());
            }

            ContratoComboBox.SelectedIndex = 0;

            if (_usuario.IsAdmin)
            {
                BtnNovoFuncionario.Visible = true;
                BtnRemoverFuncionario.Visible = true;
            }

            await AtualizarDataGrid();
        }

        // Métodos Gerais

        public async Task CarregarContratos()
        {
            // Cria os tipos de contrato CLT, JP e Autonomo se não tiver nenhum tipo salvo
            bool contratos = await ContratosRepository.ExisteContratos();
            if (contratos == false)
            {
                foreach (TiposDeContrato contrato in Enum.GetValues<TiposDeContrato>())
                {
                    string nome = contrato.ToString();
                    var novoContrato = new Contrato(nome: nome);
                    await ContratosRepository.AdicionarContratos(novoContrato);
                }
            }
        }

        public void NenhumFuncionarioEncontrado()
        {
            LabelNenhumFuncErro.Text = "NENHUM FUNCIONÁRIO FOI ENCONTRADO!";
        }

        public async Task AtualizarDataGrid(IEnumerable<Funcionario>? funcionarios = null)
        {
            try
            {
                LabelNenhumFuncErro.Text = string.Empty;
                if (funcionarios == null)
                {
                    funcionarios = await FuncionarioRepository.ObterTodos();
                }

                DgvFuncionarios.SuspendLayout();

                tabelaFuncionarios.Clear();

                foreach (var funcionario in funcionarios)
                {
                    tabelaFuncionarios.Add(funcionario);
                }

                DgvFuncionarios.ClearSelection();
                DgvFuncionarios.ResumeLayout();

                if (tabelaFuncionarios.Count <= 0)
                {
                    NenhumFuncionarioEncontrado();
                }

            }
            catch (Exception ex)
            {
                NenhumFuncionarioEncontrado();
                MessageBox.Show(
                    $"Ocorreu um erro ao atualizar os funcionários\n{ex}",
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

        private Task<IEnumerable<Funcionario>> ExtrairFuncionarios()
        {
            List<int>? funcionariosId = [];
            Task<IEnumerable<Funcionario>> funcionarios;
            foreach (DataGridViewRow row in DgvFuncionarios.SelectedRows)
            {
                Funcionario? func = row.DataBoundItem as Funcionario;
                if (func != null)
                {
                    funcionariosId.Add(func.Id);
                }
            }
            funcionarios = FuncionarioRepository.ObterPorId(funcionariosId);
            return funcionarios;
        }

        private async Task PesquisarFuncionario()
        {
            string? entrada = TextBoxBuscarFuncionario.Text.ToLower();

            if (!string.IsNullOrEmpty(entrada) && entrada.ToLower().Contains("id:"))
            {
                try
                {
                    string entradaFormatada = entrada.Replace("id:", "").Replace(" ", "").Trim();
                    if (!string.IsNullOrEmpty(entradaFormatada))
                    {
                        int id = int.Parse(entradaFormatada);
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
            else if (!string.IsNullOrEmpty(entrada) || filtroContrato != null)
            {
                Pesquisa pesquisa = new Pesquisa(entrada: entrada, filtro: filtroContrato);
                var funcionarios = await FuncionarioRepository.Pesquisar(pesquisa);
                await AtualizarDataGrid(funcionarios);
            }
            else
            {
                await AtualizarDataGrid();
            }
        }

        private async Task CadastrarFuncionario()
        {
            FormCadastroFuncionario cadastrar = new FormCadastroFuncionario();
            cadastrar.FuncionarioCadastrado += SinalFuncionarioAtualizado;
            cadastrar.ShowDialog();
        }

        private async Task EditarFuncionario()
        {
            if (DgvFuncionarios.CurrentRow != null)
            {
                Funcionario? funcionarioSelecionado = DgvFuncionarios.CurrentRow.DataBoundItem as Funcionario;

                if (funcionarioSelecionado != null)
                {
                    int funcionarioId = funcionarioSelecionado.Id;
                    var funcionario = await FuncionarioRepository.ObterPorId([funcionarioId]);

                    if (_usuario.IsAdmin == true || funcionarioId == _usuario.Id)
                    {
                        FormEditarFuncionario editor = new FormEditarFuncionario(funcionario.First());
                        editor.FuncionarioAtualizado += SinalFuncionarioAtualizado;
                        editor.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Você não tem permissão para editar esse funcionário",
                            "Erro de permissão",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        return;
                    }

                }
            }
        }

        private async void SinalFuncionarioAtualizado(object? sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        private async Task RemoverFuncionario()
        {
            int quantidadeSelecionado = DgvFuncionarios.SelectedRows.Count;

            if (quantidadeSelecionado > 0)
            {
                var funcionarios = await ExtrairFuncionarios();

                if (funcionarios.Count() > 0)
                {
                    DialogResult? removerFuncionario;

                    if (quantidadeSelecionado == 1)
                    {
                        removerFuncionario = MessageBox.Show(
                            $"Essa ação irá remover o funcionário \"{funcionarios.First().Nome}\" (Matricula: {funcionarios.First().Id})\nVocê tem certeza?",
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

                            await FuncionarioRepository.RemoverFuncionario(listIds);

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

        // Barra Superior

        private void TelaInicialButton_Click(object sender, EventArgs e)
        {
            _usuario = null;
            this.Close();
        }

        private async void TextBoxBuscarFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await PesquisarFuncionario();
            }
            else
            {
                e.Handled = true;
            }
        }

        private async void BtnLimparPesquisa_Click(object sender, EventArgs e)
        {
            TextBoxBuscarFuncionario.Text = "";
            TextBoxBuscarFuncionario.Select();
            await AtualizarDataGrid();
        }

        private void ContratoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroContrato = null;
            switch (ContratoComboBox.SelectedIndex)
            {
                case (int)TiposDeContrato.CLT:
                    filtroContrato = TiposDeContrato.CLT;
                    break;
                case (int)TiposDeContrato.PJ:
                    filtroContrato = TiposDeContrato.PJ;
                    break;
                case (int)TiposDeContrato.Autonomo:
                    filtroContrato = TiposDeContrato.Autonomo;
                    break;
                default:
                    return;
            }
        }

        private async void BtnRealizarPesquisa_Click(object sender, EventArgs e)
        {
            await PesquisarFuncionario();
        }

        private async void BtnAtualizarDgv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxBuscarFuncionario.Text))
            {
                await PesquisarFuncionario();
            }
            else
            {
                await AtualizarDataGrid();
            }
        }

        // Data Grid View

        private void DgvFuncionarios_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = DgvFuncionarios.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                DgvFuncionarios.ClearSelection();
            }
        }

        private async void ContextMenuItemNovoFunc_Click(object sender, EventArgs e)
        {
            await CadastrarFuncionario();
        }

        private async void ContextMenuItemAtualizar_Click(object sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        // Célula Funcionario

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

        private void DgvFuncionarios_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var celula = DgvFuncionarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                ContextMenuItemEditarFunc.Enabled = false;

                if (DgvFuncionarios.SelectedRows.Count <= 1 || celula.Selected == false)
                {
                    ContextMenuItemEditarFunc.Enabled = true;
                    DgvFuncionarios.ClearSelection();
                    celula.Selected = true;
                }

                e.ContextMenuStrip = funcContextMenu;
            }
        }

        private async void ContextMenuItemEditarFunc_Click(object sender, EventArgs e)
        {
            await EditarFuncionario();
        }

        private async void ContextMenuItemExcluirFunc_Click(object sender, EventArgs e)
        {
            await RemoverFuncionario();
        }

        // Barra Inferior

        private async void BtnNovoFuncionario_Click(object sender, EventArgs e)
        {
            await CadastrarFuncionario();
        }

        private async void BtnEditarFuncionario_Click(object sender, EventArgs e)
        {
            await EditarFuncionario();
        }

        private async void BtnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            await RemoverFuncionario();
        }
    }
}
