﻿using ProjetinhoComExceptionsCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Controller
{
    public class FilmeController
    {


        public Categoria EditaCategoria(Categoria categoria, string nome)
        {
            categoria.Nome = nome;
            return categoria;
        }
    }
}
