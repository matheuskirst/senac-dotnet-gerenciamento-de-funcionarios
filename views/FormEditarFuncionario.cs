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
            //TextBoxEditarNome.Text = Funcionario.Cpf;
            TextBoxEditarNome.Text = Funcionario.Email;
            TextBoxEditarNome.Text = $"R$ {Funcionario.Salario}";
        }

        private async void BtnEditarSalvar_Click(object sender, EventArgs e)
        {
            //labelErro.Text = "";

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            string? nome = TextBoxEditarNome.Text;
            string? cpf = .Text;
            string? email = TextBoxEditarEmail.Text;
            char sexo = RadioBtnEditarMasculino.Checked ? 'M' : 'F';
            string? tipoContrato = RadioBtnEditarClt.Checked ? "CLT" : RadioBtnEditarPj.Checked ? "JP" : "Autônomo";
            var dataAtualizacao = DateTime.Now;

            var funcionario = new Funcionario(
                id: Funcionario.Id,
                nome: nome,
                sexo: sexo,
                email: email,
                salario: salarioFormatado,
                tipoDeContrato: tipoContrato,
                dataDeCadastro: Funcionario.DataDeCadastro,
                dataDeAtualizacao: dataAtualizacao
                );

            var contexto = new ValidationContext(funcionario);

            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }
                //labelErro.Text = stringBuilder.ToString();
            }
            else
            {
                try
                {
                    await FuncionarioRepository.Editar(funcionario);
                    MessageBox.Show(
                        "Funcionário atualizado com sucesso!",
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
                        "Erro ao atualizar funcionário",
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
