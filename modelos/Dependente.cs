using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.modelos
{
    public class Dependente
    {
        public Dependente(
            string nome,
            string parentesco,
            DateTime? dataNascimento,
            int funcionarioId
            )
        {
            Nome = nome;
            Parentesco = parentesco;
            DataNascimento = dataNascimento;
            FuncionarioId = funcionarioId;
        }
        
        public Dependente(
            int id,
            string nome,
            string parentesco,
            DateTime? dataNascimento,
            int funcionarioId
            )
        {
            Id = id;
            Nome = nome;
            Parentesco = parentesco;
            DataNascimento = dataNascimento;
            FuncionarioId = funcionarioId;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 255 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'Parentesco' é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Parentesco' deve ter entre 3 e 255 caracteres.")]
        public string Parentesco { get; set; }

        public DateTime? DataNascimento { get; set; }

        public int FuncionarioId { get; set; }
    }
}
