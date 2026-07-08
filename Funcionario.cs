using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios
{
    internal class Funcionario(
        string nome,
        string email,
        decimal salario,
        char sexo,
        string contrato
        )
    {
        public string Nome { get; set; } = nome;
        public string Email { get; set; } = email;
        public decimal Salario { get; set; } = salario;
        public char Sexo { get; set; } = sexo;
        public string Contrato { get; set; } = contrato;
    }
}
