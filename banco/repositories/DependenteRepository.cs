using Dapper;
using GerenciamentoDeFuncionarios.banco.configuracao;
using GerenciamentoDeFuncionarios.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.banco.repositories
{
    public class DependenteRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task AdicionarDependente(Dependente dependente)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    INSERT INTO Dependente (Nome, Parentesco, DataNascimento, FuncionarioId)
                    VALUES (@Nome, @Parentesco, @DataNascimento, @FuncionarioId);
                ",
                dependente
                );
        }
        public static async Task<IEnumerable<Dependente>> ObterDependentes(int funcionarioId)
        {
            var dependentes = await ConexaoBanco.CriarConexao().QueryAsync<Dependente>(
                @"  
                    SELECT * FROM Dependente
                    WHERE FuncionarioId = @Id
                ",
                new { Id = funcionarioId }
                );
            return dependentes;
        }
    }
}