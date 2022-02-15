using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Model
{
    public class Filme
    {
        public string Nome { get; set; }
        public List<Categoria> Categorias { get; private set; }
        public int Duracao { get; }
        public string Sinopse { get; }
        public int NotaDoFilmasso { get; }

        public Filme(string nome, int duracao, string sinopse, int notaDoFilmasso, Categoria categoria)
        {
            Categorias = new List<Categoria>();
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
            NotaDoFilmasso = notaDoFilmasso;
            Categorias.Add(categoria);
        }
    }
}
