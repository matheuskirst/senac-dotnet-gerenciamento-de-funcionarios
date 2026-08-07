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

        public static async Task AdicionarFuncionario(Funcionario funcionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    INSERT INTO Funcionario (
                        Nome,
                        Cpf,
                        Email,
                        Senha,
                        Sexo,
                        Salario,
                        TipoDeContratoId,
                        DataDeCadastro,
                        DataDeAtualizacao
                        )
                    VALUES (
                        @Nome,
                        @Cpf,
                        @Email,
                        @Senha,
                        @Sexo,
                        @Salario,
                        @TipoDeContratoId,
                        @DataDeCadastro,
                        @DataDeAtualizacao
                        );
                ",
                funcionario
                );
        }

        public static async Task EditarFuncionario(Funcionario funcionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    UPDATE Funcionario
                    SET
                        Nome = @Nome,
                        Cpf = @Cpf,
                        Email = @Email,
                        Senha = @Senha,
                        Sexo = @Sexo,
                        Salario = @Salario,
                        TipoDeContratoId = @TipoDeContratoId,
                        DataDeCadastro = @DataDeCadastro,
                        DataDeAtualizacao = @DataDeAtualizacao
                    WHERE Id = @Id
                ",
                funcionario
                );
        }
        
        public static async Task RemoverFuncionario(List<int> listaIds)
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
                    SELECT 
	                    Funcionario.Id,
	                    Funcionario.Nome,
                        Funcionario.Cpf,
	                    Funcionario.Email,
	                    Funcionario.Senha,
	                    Funcionario.Sexo,
	                    Funcionario.Salario,
                        Funcionario.TipoDeContratoId,
	                    TipoDeContrato.Nome as ""TipoDeContrato"",
	                    Funcionario.DataDeCadastro,
	                    Funcionario.DataDeAtualizacao
                    FROM Funcionario
                    INNER JOIN TipoDeContrato
                    ON Funcionario.TipoDeContratoId = TipoDeContrato.Id
                    ORDER BY Funcionario.Id
                "
                );
            return funcionarios;
        }
        
        public static async Task<IEnumerable<Funcionario>> ObterPorId(List<int> funcionariosId)
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT 
	                    Funcionario.Id,
	                    Funcionario.Nome,
                        Funcionario.Cpf,
	                    Funcionario.Email,
	                    Funcionario.Senha,
	                    Funcionario.Sexo,
	                    Funcionario.Salario,
                        Funcionario.TipoDeContratoId,
	                    TipoDeContrato.Nome as ""TipoDeContrato"",
	                    Funcionario.DataDeCadastro,
	                    Funcionario.DataDeAtualizacao
                    FROM Funcionario
                    INNER JOIN TipoDeContrato
                    ON Funcionario.TipoDeContratoId = TipoDeContrato.Id
                    WHERE Funcionario.Id = ANY(@funcionariosId)
                ",
                new { FuncionariosId = funcionariosId }
                );
            return funcionarios;
        }

        public static async Task<IEnumerable<Funcionario>> Pesquisar(Pesquisa pesquisa)
        {
            var resultado = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT 
	                    Funcionario.Id,
	                    Funcionario.Nome,
                        Funcionario.Cpf,
	                    Funcionario.Email,
	                    Funcionario.Senha,
	                    Funcionario.Sexo,
	                    Funcionario.Salario,
                        Funcionario.TipoDeContratoId,
	                    TipoDeContrato.Nome as ""TipoDeContrato"",
	                    Funcionario.DataDeCadastro,
	                    Funcionario.DataDeAtualizacao
                    FROM Funcionario
                    INNER JOIN TipoDeContrato
                    ON Funcionario.TipoDeContratoId = TipoDeContrato.Id
                    WHERE (@Entrada IS NULL OR Funcionario.Nome ILIKE @Entrada)
                    AND (@Filtro IS NULL OR Funcionario.TipoDeContratoId = @Filtro)

                    UNION

                    SELECT 
	                    Funcionario.Id,
	                    Funcionario.Nome,
                        Funcionario.Cpf,
	                    Funcionario.Email,
	                    Funcionario.Senha,
	                    Funcionario.Sexo,
	                    Funcionario.Salario,
                        Funcionario.TipoDeContratoId,
	                    TipoDeContrato.Nome as ""TipoDeContrato"",
	                    Funcionario.DataDeCadastro,
	                    Funcionario.DataDeAtualizacao
                    FROM Funcionario
                    INNER JOIN TipoDeContrato
                    ON Funcionario.TipoDeContratoId = TipoDeContrato.Id
                    WHERE (@Entrada IS NULL OR Funcionario.Cpf ILIKE @Entrada)
                    AND (@Filtro IS NULL OR Funcionario.TipoDeContratoId = @Filtro)

                    UNION

                    SELECT 
	                    Funcionario.Id,
	                    Funcionario.Nome,
                        Funcionario.Cpf,
	                    Funcionario.Email,
	                    Funcionario.Senha,
	                    Funcionario.Sexo,
	                    Funcionario.Salario,
                        Funcionario.TipoDeContratoId,
	                    TipoDeContrato.Nome as ""TipoDeContrato"",
	                    Funcionario.DataDeCadastro,
	                    Funcionario.DataDeAtualizacao
                    FROM Funcionario
                    INNER JOIN TipoDeContrato
                    ON Funcionario.TipoDeContratoId = TipoDeContrato.Id
                    WHERE (@Entrada IS NULL OR Funcionario.Email ILIKE @Entrada)
                    AND (@Filtro IS NULL OR Funcionario.TipoDeContratoId = @Filtro)
                ",
                pesquisa
                );
            return resultado;
        }

        public static async Task<IEnumerable<Funcionario>> PesquisarId(int id)
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT 
	                    Funcionario.Id,
	                    Funcionario.Nome,
                        Funcionario.Cpf,
	                    Funcionario.Email,
	                    Funcionario.Senha,
	                    Funcionario.Sexo,
	                    Funcionario.Salario,
                        Funcionario.TipoDeContratoId,
	                    TipoDeContrato.Nome as ""TipoDeContrato"",
	                    Funcionario.DataDeCadastro,
	                    Funcionario.DataDeAtualizacao
                    FROM Funcionario
                    INNER JOIN TipoDeContrato
                    ON Funcionario.TipoDeContratoId = TipoDeContrato.Id
                    WHERE Funcionario.Id = @Id
                ",
                new { Id = id }
                );
            return funcionarios;
        }

        public static async Task<bool> ExisteFuncionarioComId(int id)
        {
            return await ConexaoBanco.CriarConexao().ExecuteScalarAsync<bool>(
                @"
                SELECT EXISTS (
                    SELECT 1
                    FROM Funcionario
                    WHERE Id = @Id
                )
                ",
                new { Id = id }
            );
        }        
        
        public static async Task<bool> ExisteFuncionarioComCpf(string cpf)
        {
            return await ConexaoBanco.CriarConexao().ExecuteScalarAsync<bool>(
                @"
                SELECT EXISTS (
                    SELECT 1
                    FROM Funcionario
                    WHERE Cpf = @Cpf
                )
                ",
                new { Cpf = cpf }
                );
        }

        public static async Task<bool> ExisteFuncionarioComEmail(string email)
        {
            return await ConexaoBanco.CriarConexao().ExecuteScalarAsync<bool>(
                @"
                SELECT EXISTS (
                    SELECT 1
                    FROM Funcionario
                    WHERE Email = @Email
                )
                ",
                new { Email = email }
                );
        }
    }
}
