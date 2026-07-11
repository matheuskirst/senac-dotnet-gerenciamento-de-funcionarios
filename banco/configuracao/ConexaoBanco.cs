using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace GerenciamentoDeFuncionarios.banco.configuracao
{
    public class ConexaoBanco
    {
        public IDbConnection CriarConexao()
        {
            DotNetEnv.Env.Load();

            string? dbConn = Environment.GetEnvironmentVariable("DB_CONNECTION");

            return new NpgsqlConnection(dbConn);
        }
    }
}