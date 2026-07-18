using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using GerenciamentoDeFuncionarios.banco.configuracao;
using GerenciamentoDeFuncionarios.modelos;

namespace GerenciamentoDeFuncionarios.banco.repositories
{
    public class FuncionarioRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();
        public static async Task Adicionar(Funcionario funcionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    INSERT INTO Funcionario (
                        Nome,
                        Cpf,
                        Email,
                        Sexo,
                        Salario,
                        TipoDeContrato,
                        DataDeCadastro,
                        DataDeAtualizacao
                        )    
                    VALUES (
                        @Nome,
                        @Cpf,
                        @Email,
                        @Sexo,
                        @Salario,
                        @TipoDeContrato,
                        @DataDeCadastro,
                        @DataDeAtualizacao
                        );
                ",
                funcionario
                );
        }

        public static async Task Editar(Funcionario funcionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    UPDATE Funcionario
                    SET
                        Nome = @Nome,
                        Cpf = @Cpf,
                        Email = @Email,
                        Sexo = @Sexo,
                        Salario = @Salario,
                        TipoDeContrato = @TipoDeContrato,
                        DataDeCadastro = @DataDeCadastro,
                        DataDeAtualizacao = @DataDeAtualizacao
                    WHERE Id = @Id
                ",
                funcionario
                );
        }
        
        public static async Task Remover(List<int> listaIds)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    DELETE FROM Funcionario
                    WHERE Id = ANY(@ListaIds)
                ",
                new { ListaIds = listaIds }
                );
        }
        
        public static async Task<IEnumerable<Funcionario>> ObterTodos()
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT * FROM Funcionario
                    ORDER BY Id
                "
                );
            return funcionarios;
        }

        public static async Task<IEnumerable<Funcionario>> PesquisaGeral(object entry)
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT * FROM Funcionario
                    WHERE Nome ILIKE @Entry

                    UNION

                    SELECT * FROM Funcionario
                    WHERE Cpf ILIKE @Entry

                    UNION

                    SELECT * FROM Funcionario
                    WHERE Email ILIKE @Entry
                ",
                new { Entry = $"{entry}%"}
                );
            return funcionarios;
        }

        public static async Task<IEnumerable<Funcionario>> PesquisarId(int id)
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT * FROM Funcionario
                    WHERE Id = @Id
                ",
                new { Id = id }
                );
            return funcionarios;
        }

        public static async Task<bool> ExisteFuncionarioComCpf(string cpf)
        {
            var resultado = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Funcionario>(
                @"
                    SELECT * FROM Funcionario
                    WHERE Cpf = @Cpf
                ",
                new { Cpf = cpf }
                );
            return resultado != null;
        }

        public static async Task<bool> ExisteFuncionarioComEmail(string email)
        {
            var resultado = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Funcionario>(
                @"
                    SELECT * FROM Funcionario
                    WHERE Email = @Email
                ",
                new { Email = email }
                );
            return resultado != null;
        }
    }
}
