using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.modelos
{
    public class Funcionario(
        string nome,
        string email,
        decimal salario,
        char sexo,
        string contrato,
        DateTime dataDeCadastro
        )
    {
        public string Nome { get; private set; } = nome;
        public string Email { get; private set; } = email;
        public decimal Salario { get; private set; } = salario;
        public char Sexo { get; private set; } = sexo;
        public string TipoDeContrato { get; private set; } = contrato;

        public DateTime DataDeCadastro { get; private set; } = dataDeCadastro;
        public DateTime? DataDeAtualizacao { get; set; }
    }
}
