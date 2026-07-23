using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.modelos
{
    public class Usuario(int? id = null, bool is_admin = false)
    {
        public int? Id { get; set; } = id;
        public bool IsAdmin { get; set; } = is_admin;
    }
}
