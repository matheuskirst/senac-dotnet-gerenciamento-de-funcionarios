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
        public static void Adicionar(Funcionario funcionario)
        {
            ConexaoBanco.CriarConexao().QueryAsync(
                @"  
                    INSERT INTO Funcionario (Nome, Email, Salario, Sexo, TipoDeContrato, DataDeCadastro, DataDeAtualizacao)    
                    VALUES (@Nome, @Email, @Salario, @Sexo, @TipoDeContrato, @DataDeCadastro, @DataDeAtualizacao);
                "
                );
        }
    }
}
