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
    public partial class FormCadastroFuncionario : Form
    {
        CultureInfo brazilCulture = new CultureInfo("pt-BR");
        string salarioDigitado = "";
        decimal salarioFormatado = 0;
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            TxtBoxCadastroSalario.Text = "R$ 0,00";
        }
        private void MTxtBoxCadastroCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AtualizarTextBoxSalario()
        {
            if (string.IsNullOrEmpty(salarioDigitado))
            {
                salarioFormatado = 0;
            }
            TxtBoxCadastroSalario.Text = "";
            TxtBoxCadastroSalario.Text = salarioFormatado.ToString("C", brazilCulture);
            TxtBoxCadastroSalario.Select(TxtBoxCadastroSalario.Text.Length, 0);
        }

        private void TxtBoxCadastroSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (salarioDigitado != "")
                {
                    salarioDigitado = salarioDigitado.Remove(salarioDigitado.Length - 1);
                    if (!string.IsNullOrEmpty(salarioDigitado))
                    {
                        salarioFormatado = decimal.Parse(salarioDigitado) / 100;
                    }
                    AtualizarTextBoxSalario();
                }
            }
        }

        private void TxtBoxCadastroSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains(','))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                salarioDigitado += e.KeyChar.ToString();

                salarioFormatado = decimal.Parse(salarioDigitado) / 100;

                AtualizarTextBoxSalario();
            }
        }

        private async void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            string? nome = TxtBoxCadastroNome.Text;
            string? cpf = MTxtBoxCadastroCpf.Text;
            string? email = TxtBoxCadastroEmail.Text;
            char sexo = RadioBtnMasculino.Checked ? 'M' : 'F';
            string? tipoContrato = RadioBtnContratoClt.Checked ? "CLT" : RadioBtnContratoPj.Checked ? "PJ" : "Autônomo";
            var dataCadastro = DateTime.Now;

            var funcionario = new Funcionario(
                nome: nome,
                sexo: sexo,
                email: email,
                salario: salarioFormatado,
                tipoDeContrato: tipoContrato,
                dataDeCadastro: dataCadastro
                );

            var contexto = new ValidationContext(funcionario);

            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }
                labelErro.Text = stringBuilder.ToString();
            }
            else
            {
                try
                {
                    await FuncionarioRepository.Adicionar(funcionario);
                    MessageBox.Show(
                        "Funcionário cadastrado com sucesso!",
                        "Operação concluida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(
                        "Erro ao salvar para o banco de dados.",
                        "Erro ao cadastrar funcionário",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            salarioDigitado = "";
            salarioFormatado = 0;
        }
    }
}
