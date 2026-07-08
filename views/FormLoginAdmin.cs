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
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, MouseEventArgs e)
        {
            if (txtBoxUser.Text == "admin" && txtBoxPassword.Text == "1234")
            {
                this.Hide();
                new FormTelaPrincipal().ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos.",
                    "Erro ao fazer login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
