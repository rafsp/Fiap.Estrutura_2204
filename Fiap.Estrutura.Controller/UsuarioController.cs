using Fiap.Estrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Estrutura.Controller
{
    public  class UsuarioController
    {
        public bool validarUsuarioSenha(string usuario, string senha)
        {
            UsuarioRepository repositorio = new UsuarioRepository();
            return repositorio.validarLogin(usuario, senha);
        }
    }
}
