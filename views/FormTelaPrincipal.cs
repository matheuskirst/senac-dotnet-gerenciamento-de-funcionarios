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
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();

            Load += FormTelaPrincipal_Load;
        }

        private void FormTelaPrincipal_Load(object? sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public async void AtualizarGrid()
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            new FormCadastroFuncionario().ShowDialog();
            AtualizarGrid();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
