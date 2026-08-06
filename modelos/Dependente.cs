using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.modelos
{
    public class Dependente
    {
        public Dependente(
            int id,
            string nome,
            DateTime dataNascimento,
            Funcionario parentesco
            )
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Parentesco = parentesco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Funcionario Parentesco {  get; set; }

    }
}
