using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Model
{
    public class Categoria
    {
        public static int TotalDeCategorias { get; private set; }
        public string  Nome { get;}
        public Categoria(string nome)
        {
            TotalDeCategorias++;
            Nome = nome;
        }
    }
}
