using System;
using System.Collections.Generic;
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
                        Email,
                        Sexo,
                        Salario,
                        TipoDeContrato,
                        DataDeCadastro,
                        DataDeAtualizacao
                        )    
                    VALUES (
                        @Nome,
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
                    UPDATE Funcionario (
                        Nome,
                        Email,
                        Sexo,
                        Salario,
                        TipoDeContrato,
                        DataDeCadastro,
                        DataDeAtualizacao
                        )    
                    SET
                        Nome = @Nome,
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
        
        public static async Task Remover(Funcionario funcionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    DELETE FROM Funcionario
                    WHERE Id = @Id
                ",
                funcionario
                );
        }
        
        public static async Task<IEnumerable<Funcionario>> ObterTodos()
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT
                        Id,
                        Nome,
                        Email,
                        Sexo,
                        Salario,
                        TipoDeContrato,
                        DataDeCadastro,
                        DataDeAtualizacao
                    FROM
                        Funcionario
                "
                );
            return funcionarios;
        }
    }
}
