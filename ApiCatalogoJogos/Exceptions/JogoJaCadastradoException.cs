using System;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Legal! O jogo está cadastrado :)")
        { }
    }
}
