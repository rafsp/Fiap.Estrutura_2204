using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Estrutura.Model
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NomeUsuario { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
