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
    public partial class FormLoginFuncionario : Form
    {
        public FormLoginFuncionario()
        {
            InitializeComponent();
        }

        private async void BtnFuncLogin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtBoxFuncMatricula.Text, out var funcionarioId))
            {
                bool funcionarioExiste = await FuncionarioRepository.ExisteFuncionarioComId(funcionarioId);

                if (funcionarioExiste)
                {
                    var usuario = new Usuario(id: funcionarioId, is_admin: false);
                    this.Hide();
                    new FormTelaPrincipal(usuario).ShowDialog();
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
    }
}
