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
            string cpf,
            string email,
            string senha,
            char sexo,
            decimal salario,
            string tipoDeContrato,
            DateTime dataDeCadastro
            )
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Sexo = sexo;
            Salario = salario;
            TipoDeContrato = tipoDeContrato;
            DataDeCadastro = dataDeCadastro;
        }

        public Funcionario(
            int id,
            string nome,
            string cpf,
            string email,
            string senha,
            char sexo,
            decimal salario,
            string tipoDeContrato,
            DateTime dataDeCadastro,
            DateTime? dataDeAtualizacao
            )
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
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

        [Required(ErrorMessage = "O campo 'CPF' é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo 'CPF' deve ter 11 caracteres.")]
        public string Cpf { get; private set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório.")]
        [EmailAddress(ErrorMessage = "O 'Email' é inválido.")]
        public string Email { get; private set; }

        public string Senha { get; private set; }

        public char Sexo { get; private set; }

        [Range(0.00, 99999999.99, ErrorMessage = "O valor de 'Salário' deve ser entre R$ 0,00 e R$ 99.999.999,99")]
        public decimal Salario { get; private set; }

        public string TipoDeContrato { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeAtualizacao { get; set; }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }

        public void SetSexo(char sexo)
        {
            Sexo = sexo;
        }

        public void SetSalario(decimal salario)
        {
            Salario = salario;
        }

        public void SetTipoDeContrato(string tipoDeContrato)
        {
            TipoDeContrato = tipoDeContrato;
        }
    }
}
