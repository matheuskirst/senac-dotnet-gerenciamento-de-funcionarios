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

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            string? nome = txtBoxFuncNome.Text;
            string? email = txtBoxFuncEmail.Text;
            string? salario = txtBoxFuncSalario.Text;
            char sexo = radioBtnMasculino.Checked ? 'M' : 'F';
            string? contrato;
            var dataCadastro = DateTime.Now;

            if (radioBtnContratoClt.Checked)
            {
                contrato = "CLT";
            }
            else if (radioBtnContratoPj.Checked)
            {
                contrato = "PJ";
            }
            else
            {
                contrato = "Autônomo";
            }
            
            if (nome == "" && email == "" && salario == "")
            {
                MessageBox.Show(
                    "Os campos de cadastro estão vazio!.",
                    "Erro ao criar usuário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (nome == "")
            {
                MessageBox.Show(
                    "Campo 'Nome' está vazio!.",
                    "Erro ao criar usuário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (email == "")
            {
                MessageBox.Show(
                    "Campo 'E-mail' está vazio!.",
                    "Erro ao criar usuário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (salario == "")
            {
                MessageBox.Show(
                    "Campo 'Salário' está vazio!.",
                    "Erro ao criar usuário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (decimal.TryParse(salario, out decimal salarioValor))
                {
                    new Funcionario(
                        nome: nome,
                        email: email,
                        salario: salarioValor,
                        sexo: sexo,
                        contrato: contrato
                        );
                }
            }
        }
    }
}
