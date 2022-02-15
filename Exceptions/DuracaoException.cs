using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Exceptions
{
    public class DuracaoException : ArgumentException
    {
        public DuracaoException(){}
        public DuracaoException(string mensagem) : base(mensagem){}
    }
}
