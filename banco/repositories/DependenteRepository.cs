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

        public static async Task AdicionarDependente(Contrato contrato)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    INSERT INTO Dependente (Nome, Parentesco, DataNascimento, FuncionarioId)
                    VALUES (@Nome, @Parentesco, @DataNascimento, @FuncionarioId);
                ",
                contrato
                );
        }
        public static async Task<bool> ExisteContratos()
        {
            var resultado = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Contrato>(
                @"
                    SELECT * FROM TipoDeContrato
                "
                );
            return resultado != null;
        }
    }
}
}
