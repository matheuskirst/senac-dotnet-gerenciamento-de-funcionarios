using GerenciamentoDeFuncionarios.banco.repositories;
using GerenciamentoDeFuncionarios.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            Load += FormTelaPrincipal_Load;
        }

        private void FormTelaPrincipal_Load(object? sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        public async void AtualizarDataGrid()
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            DgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
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

        private void BtnNovoFuncionario_Click(object sender, EventArgs e)
        {
            new FormCadastroFuncionario().ShowDialog();
            AtualizarDataGrid();
        }

        private void BtnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (DgvFuncionarios.CurrentRow != null)
            {
                Funcionario? funcionario = DgvFuncionarios.CurrentRow.DataBoundItem as Funcionario;

                if (funcionario != null)
                {
                    new FormEditarFuncionario(funcionario).ShowDialog();

                    AtualizarDataGrid();
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
                    }
                    AtualizarDataGrid();
                }
            }
        }
    }
}
