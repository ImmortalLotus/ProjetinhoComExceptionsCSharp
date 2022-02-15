using ProjetinhoComExceptionsCSharp.Exceptions;
using ProjetinhoComExceptionsCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Controller
{
    public class FilmeController
    {
        public Filme CriaFilme(string nome, int duracao, string sinopse, int notaDoFilmasso, Categoria categoria)
        {

            return new Filme(nome,duracao, sinopse,notaDoFilmasso, categoria);
        }

        public Filme CriaFilme(string nome, int duracao, string sinopse, int notaDoFilmasso, string nomeCategoria)
        {
            CategoriaController categoriaController = new CategoriaController();
            Categoria categoria;
            categoria = categoriaController.CriaCategoria(nomeCategoria);
            return new Filme(nome, duracao, sinopse, notaDoFilmasso, categoria);
        }

        public Categoria AdicionaCategoria(Categoria categoria, Filme filme)
        {
            filme.Categorias.Add(categoria);
            return categoria;
        }

        public Filme EditarFilme(Filme filme, Filme novoFilme)
        {
            filme = novoFilme;
            return filme;
        }

        public Categoria EditaCategoria(Categoria categoria, string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser vazio");
            }
            if (nome.Length<4)
            {
                throw new NomeException(" o nome deve ter mais de 4 carateres");
            }
            categoria.Nome = nome;
            return categoria;
        }
    }
}
