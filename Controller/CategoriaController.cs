using ProjetinhoComExceptionsCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Controller
{
    public class CategoriaController
    {
        public Categoria CriaCategoria(string nome)
        {
            return new Categoria(nome);
        }
    }
}
