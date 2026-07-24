using GerenciamentoDeFuncionarios.modelos;
using GerenciamentoDeFuncionarios.views;

namespace GerenciamentoDeFuncionarios
{
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void BtnIdentificacaoAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLoginAdmin().ShowDialog();
            this.Show();
        }

        private void BtnIdentificacaoFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLoginFuncionario().ShowDialog();
            this.Show();
        }
    }
}
