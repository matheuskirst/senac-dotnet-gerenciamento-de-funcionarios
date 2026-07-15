using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.modelos
{
    public class Funcionario
    {
        public Funcionario(
            string nome,
            string email,
            char sexo,
            decimal salario,
            string tipoDeContrato,
            DateTime dataDeCadastro
            )
        {
            Nome = nome;
            Email = email;
            Sexo = sexo;
            Salario = salario;
            TipoDeContrato = tipoDeContrato;
            DataDeCadastro = dataDeCadastro;
        }

        public Funcionario(
            int id,
            string nome,
            string email,
            char sexo,
            decimal salario,
            string tipoDeContrato,
            DateTime dataDeCadastro,
            DateTime? dataDeAtualizacao
            )
        {
            Id = id;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            Salario = salario;
            TipoDeContrato = tipoDeContrato;
            DataDeCadastro = dataDeCadastro;
            DataDeAtualizacao = dataDeAtualizacao;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 255 caracteres.")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório.")]
        [EmailAddress(ErrorMessage = "O 'Email' é inválido.")]
        public string Email { get; private set; }

        public char Sexo { get; private set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O 'Salário' não pode ter mais de duas casas decimais")]
        public decimal Salario { get; private set; }

        public string TipoDeContrato { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeAtualizacao { get; set; }
    }
}
