using ProjetinhoComExceptionsCSharp.Controller;
using ProjetinhoComExceptionsCSharp.Exceptions;
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
        public string Nome { get; set; }        
        public Categoria(string nome)
        {
            TotalDeCategorias++;
            if (Nome.Length<4)
            {
                throw new NomeException(" O nome da categoria não pode ter menos que 4 dígitos");
            }
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser vazio cara coé");
            }
            Nome = nome;
        }
    }
}
