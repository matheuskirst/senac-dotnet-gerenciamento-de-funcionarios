using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.modelos
{
    public class Contrato
    {
        public Contrato(string nome)
        {
            Nome = nome;
        }

        public Contrato(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
