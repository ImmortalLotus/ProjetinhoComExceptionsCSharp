using ProjetinhoComExceptionsCSharp.Exceptions;
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
            if (Nome.Length < 4)
            {
                throw new NomeException(" O nome da categoria não pode ter menos que 4 dígitos");
            }
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser vazio cara coé");
            }
            Nome = nome;
            if (duracao < 60)
            {
                throw new DuracaoException("A duração deve ser maior que 60 minutos.");
            }
            Duracao = duracao;
            if (sinopse.Length < 500 )
            {
                throw new SinopseException();
            }
            if (string.IsNullOrEmpty(sinopse))
            {
                throw new ArgumentException(" A sinopse não pode ser vazia mané");
            }
            Sinopse = sinopse;
            if (NotaDoFilmasso < 0)
            {
                throw new ArgumentException(" As notas do filmasso devem ser positivas");
            }
            NotaDoFilmasso = notaDoFilmasso;
            Categorias.Add(categoria);
        }
    }
}
