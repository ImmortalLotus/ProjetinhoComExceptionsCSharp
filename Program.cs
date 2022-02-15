using ProjetinhoComExceptionsCSharp.Model;
using System;

namespace ProjetinhoComExceptionsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria categoria = new Categoria("ola");
            Filme filme = new Filme("ola",1,"sim",1,categoria);
            Console.WriteLine("Hello World!");

        }
    }
}
