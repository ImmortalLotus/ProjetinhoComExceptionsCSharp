using ProjetinhoComExceptionsCSharp.Controller;
using ProjetinhoComExceptionsCSharp.Model;
using System;

namespace ProjetinhoComExceptionsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriaController categoriaController = new CategoriaController();
            Categoria categoria = categoriaController.CriaCategoria("Nome");
            Console.WriteLine("o nome da classe é: " + categoria.Nome);
            Filme filme = new Filme("ola",1,"sim",1,categoria);
            Console.WriteLine("Hello World!");
        }
    }
}
