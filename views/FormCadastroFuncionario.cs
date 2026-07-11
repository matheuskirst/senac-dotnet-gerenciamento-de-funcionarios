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
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }

        private async void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            string? nome = txtBoxFuncNome.Text;
            string? email = txtBoxFuncEmail.Text;
            char sexo = radioBtnMasculino.Checked ? 'M' : 'F';
            string? salario = txtBoxFuncSalario.Text;
            string? tipoContrato = radioBtnContratoClt.Checked ? "CLT" : radioBtnContratoPj.Checked ? "JP" : "Autônomo";
            var dataCadastro = DateTime.Now;

            if (nome == "" && email == "" && salario == "")
            {
                MessageBox.Show(
                    "Os campos de cadastro estão vazio!.",
                    "Erro ao cadastrar funcionário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (nome == "")
            {
                MessageBox.Show(
                    "Campo 'Nome' está vazio!.",
                    "Erro ao cadastrar funcionário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (email == "")
            {
                MessageBox.Show(
                    "Campo 'E-mail' está vazio!.",
                    "Erro ao cadastrar funcionário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (salario == "")
            {
                MessageBox.Show(
                    "Campo 'Salário' está vazio!.",
                    "Erro ao cadastrar funcionário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (decimal.TryParse(salario, out decimal salarioValor))
                {
                    var funcionario = new Funcionario(
                        nome: nome,
                        cpf: cpf,
                        sexo: sexo,
                        email: email,
                        salario: salarioValor,
                        tipoDeContrato: tipoContrato,
                        dataDeCadastro: dataCadastro
                        );

                    try
                    {
                        await FuncionarioRepository.Adicionar(funcionario);
                        MessageBox.Show(
                            "Funcionário cadastrado com sucesso",
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
}
