using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoComExceptionsCSharp.Exceptions
{
    public class SinopseException : ArgumentException
    {
        public SinopseException(){}
        public SinopseException(string mensagem) : base(mensagem){}
    }
}
