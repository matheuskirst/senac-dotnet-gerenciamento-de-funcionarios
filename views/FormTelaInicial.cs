using GerenciamentoDeFuncionarios.views;

namespace GerenciamentoDeFuncionarios
{
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new FormTelaAdmin().ShowDialog();
            this.Show();
        }
    }
}
