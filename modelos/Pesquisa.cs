using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.modelos
{
    public class Pesquisa
    {
        public Pesquisa(string? entrada=null, TiposDeContrato? filtro=null)
        {

            if (!string.IsNullOrEmpty(entrada))
            {
                Entrada = $"{entrada}%";
            }

            if (filtro != null)
            {
                Filtro = (int)filtro;
            }
        }
        public string? Entrada { get; set; }
        public int? Filtro { get; set; }
    }
}
