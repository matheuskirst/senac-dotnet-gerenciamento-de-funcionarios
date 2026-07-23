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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.views
{
    public partial class FormEditarFuncionario : Form
    {
        public event EventHandler? FuncionarioAtualizado;

        CultureInfo brazilCulture = new CultureInfo("pt-BR");
        string salarioDigitado = "";
        decimal salarioFormatado = 0;
        public Funcionario Funcionario { get; set; }

        public FormEditarFuncionario(Funcionario funcionario)
        {
            Funcionario = funcionario;

            InitializeComponent();
        }

        private void FormEditarFuncionario_Load(object sender, EventArgs e)
        {
            TextBoxEditarNome.Text = Funcionario.Nome;
            MTextBoxEditarCpf.Text = Funcionario.Cpf;
            TextBoxEditarEmail.Text = Funcionario.Email;
            salarioDigitado = Funcionario.Salario.ToString().Replace(",", "").Replace(".", "");
            salarioFormatado = Funcionario.Salario;
            AtualizarTextBoxSalario();
            if (Funcionario.Sexo == 'M') { RadioBtnEditarMasculino.Checked = true; }
            else { RadioBtnEditarFeminino.Checked = true; }

            switch (Funcionario.TipoDeContrato)
            {
                case "CLT":
                    RadioBtnEditarClt.Checked = true;
                    break;
                case "PJ":
                    RadioBtnEditarPj.Checked = true;
                    break;
                case "Autonomo":
                    RadioBtnEditarAutonomo.Checked = true;
                    break;
                default:
                    RadioBtnEditarClt.Checked = true;
                    break;
            }
        }

        private void AtualizarTextBoxSalario()
        {
            if (string.IsNullOrEmpty(salarioDigitado))
            {
                salarioFormatado = 0;
            }
            TextBoxEditarSalario.Text = "";
            TextBoxEditarSalario.Text = salarioFormatado.ToString("C", brazilCulture);
            TextBoxEditarSalario.Select(TextBoxEditarSalario.Text.Length, 0);
        }

        private void TextBoxEditarSalario_KeyDown(object sender, KeyEventArgs e)
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

        private void TextBoxEditarSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                salarioDigitado += e.KeyChar.ToString();

                salarioFormatado = decimal.Parse(salarioDigitado) / 100;

                AtualizarTextBoxSalario();
            }
        }

        private async void BtnEditarSalvar_Click(object sender, EventArgs e)
        {
            LabelEditarErro.Text = "";

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            string? nome = TextBoxEditarNome.Text;
            string? cpf = MTextBoxEditarCpf.Text;
            string? email = TextBoxEditarEmail.Text;
            char sexo = RadioBtnEditarMasculino.Checked ? 'M' : 'F';
            string? tipoContrato = RadioBtnEditarClt.Checked ? "CLT" : RadioBtnEditarPj.Checked ? "PJ" : "Autônomo";
            var dataAtualizacao = DateTime.Now;

            if (!string.IsNullOrEmpty(cpf))
            {
                if (cpf != Funcionario.Cpf)
                {
                    bool cpfExiste = await FuncionarioRepository.ExisteFuncionarioComCpf(cpf);

                    if (cpfExiste == true)
                    {
                        var erroCpfJaExiste = new ValidationResult("Este CPF já está cadastrado!");
                        listaDeErros.Add(erroCpfJaExiste);
                    }
                }
            }

            if (!string.IsNullOrEmpty(email))
            {
                if (email != Funcionario.Email)
                {
                    bool emailExiste = await FuncionarioRepository.ExisteFuncionarioComEmail(email);

                    if (emailExiste == true)
                    {
                        var erroEmailJaExiste = new ValidationResult("Este Email já está cadastrado!");
                        listaDeErros.Add(erroEmailJaExiste);
                        email = Funcionario.Email;
                    }
                }
            }

            if (nome == Funcionario.Nome &&
                cpf == Funcionario.Cpf &&
                email == Funcionario.Email &&
                sexo == Funcionario.Sexo &&
                salarioFormatado == Funcionario.Salario &&
                tipoContrato == Funcionario.TipoDeContrato
                )
            {
                this.Close();
            }
            else
            {
                Funcionario.SetCpf(cpf);
                Funcionario.SetEmail(email);
                Funcionario.SetSexo(sexo);
                Funcionario.SetSalario(salarioFormatado);
                Funcionario.SetTipoDeContrato(tipoContrato);
                Funcionario.DataDeAtualizacao = dataAtualizacao;

                var contexto = new ValidationContext(Funcionario);

                Validator.TryValidateObject(Funcionario, contexto, listaDeErros, true);

                if (listaDeErros.Count > 0)
                {
                    foreach (var erro in listaDeErros)
                    {
                        stringBuilder.Append(erro.ErrorMessage + "\n");
                    }
                    LabelEditarErro.Text = stringBuilder.ToString();
                }
                else
                {
                    try
                    {
                        await FuncionarioRepository.Editar(Funcionario);
                        MessageBox.Show(
                            "Funcionário atualizado com sucesso!",
                            "Operação concluida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        FuncionarioAtualizado?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Erro ao atualizar funcionário.",
                            "Erro ao salvar para o banco de dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
            }
        }
    }
}
