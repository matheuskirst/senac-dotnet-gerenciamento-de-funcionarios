using GerenciamentoDeFuncionarios.banco.repositories;
using GerenciamentoDeFuncionarios.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.views
{
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }

        private async void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            labelNome.ForeColor = Color.Black;
            labelCpf.ForeColor = Color.Black;
            labelEmail.ForeColor = Color.Black;
            labelSalario.ForeColor = Color.Black;
            labelErro.Text = "";

            string? nome = txtBoxFuncNome.Text;
            string? cpf = mTxtBoxCpf.Text;
            string? email = txtBoxFuncEmail.Text;
            char sexo = radioBtnMasculino.Checked ? 'M' : 'F';
            decimal salario = 0;
            if (!string.IsNullOrEmpty(txtBoxFuncSalario.Text))
            {
                salario = decimal.Parse(txtBoxFuncSalario.Text);
            }
            string? tipoContrato = radioBtnContratoClt.Checked ? "CLT" : radioBtnContratoPj.Checked ? "JP" : "Autônomo";
            var dataCadastro = DateTime.Now;

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var funcionario = new Funcionario(
                nome: nome,
                sexo: sexo,
                email: email,
                salario: salario,
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

        }
    }
}
