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
    public class ContratosRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task AdicionarContratos(Contrato contrato)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    INSERT INTO TipoDeContrato (Nome)
                    VALUES (@Nome);
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
