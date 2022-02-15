using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Exceptions
{
    public class NomeException : Exception
    {
        public NomeException(){}
        public NomeException(string mensagem) : base(mensagem){}
    }
}
