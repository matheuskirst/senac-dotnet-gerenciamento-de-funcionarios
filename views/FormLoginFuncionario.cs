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
using System.Net.Mail;
using BCrypt.Net;

namespace GerenciamentoDeFuncionarios.views
{
    public partial class FormLoginFuncionario : Form
    {
        public FormLoginFuncionario()
        {
            InitializeComponent();
        }

        private async void BtnFuncLogin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtBoxMatriculaFunc.Text, out var funcionarioId))
            {
                bool isFuncionarioExiste = await FuncionarioRepository.ExisteFuncionarioComId(funcionarioId);

                if (isFuncionarioExiste)
                {
                    var funcionarios = await FuncionarioRepository.ObterPorId([funcionarioId]);
                    Funcionario? funcionario = funcionarios.First();

                    string loginSenha = TxtBoxSenhaFunc.Text;
                    string senhaSalva = funcionario.Senha;

                    bool isSenhaValida = BCrypt.Net.BCrypt.EnhancedVerify(loginSenha, senhaSalva);

                    if (isSenhaValida)
                    {
                        var usuario = new Usuario(id: funcionarioId, is_admin: false);
                        this.Hide();
                        new FormTelaPrincipal(usuario).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            "A matrícula ou a senha estão incorretos.",
                            "Erro no login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Funcionário não encontrado.",
                        "Erro no login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            else
            {
                MessageBox.Show(
                    "Mátricula inválida!",
                    "Erro no Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void VoltarButtonFunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
