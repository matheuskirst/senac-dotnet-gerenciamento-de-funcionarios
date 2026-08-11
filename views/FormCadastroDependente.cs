using GerenciamentoDeFuncionarios.banco.repositories;
using GerenciamentoDeFuncionarios.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.views
{
    public partial class FormCadastroDependente : Form
    {
        private Funcionario Funcionario;

        private DateTime? dataNascimento;

        public FormCadastroDependente(Funcionario funcionario)
        {
            Funcionario = funcionario;

            InitializeComponent();
        }

        private void FormCadastroDependente_Load(object sender, EventArgs e)
        {
            LabelFuncMatriculaPlaceholder.Text = Funcionario.Id.ToString();
            LabelFuncNomePlaceholder.Text = Funcionario.Nome;
        }

        private void InserirDataNascimento()
        {
            if (dataNascimento != null)
            {
                mTxtBoxDependenteData.Text = dataNascimento?.ToString("d", new CultureInfo("pt-BR"));
            }
        }

        private void BtnDependenteSelecionarData_Click(object sender, EventArgs e)
        {
            MonthCalendarDependente.Location = new Point(BtnDependenteSelecionarData.Left, BtnDependenteSelecionarData.Bottom);
            MonthCalendarDependente.Visible = true;
            MonthCalendarDependente.BringToFront();
        }

        private void MonthCalendarDependente_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = e.Start;
            dataNascimento = dataSelecionada;
            MonthCalendarDependente.Visible = false;
            InserirDataNascimento();
        }

        private async void BtnCriarDependente_Click(object sender, EventArgs e)
        {
            LabelDependenteErro.Text = "";

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            string? nome = TxtBoxDependenteNome.Text;
            string? parentesco = TxtBoxDependenteParentesco.Text;
            DateTime? dataDeNascimento = dataNascimento;

            var dependente = new Dependente(
                nome: nome,
                parentesco: parentesco,
                dataNascimento: dataDeNascimento,
                funcionarioId: Funcionario.Id
                );

            var contexto = new ValidationContext(dependente);

            Validator.TryValidateObject(dependente, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }
                LabelDependenteErro.Text = stringBuilder.ToString();
            }
            else
            {
                try
                {
                    await DependenteRepository.AdicionarDependente(dependente);
                    MessageBox.Show(
                        "Dependente cadastrado com sucesso!",
                        "Operação concluida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(
                        $"Ocorreu um erro no cadastro do Dependente.",
                        "Erro na conexão do banco de dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }
    }
}
