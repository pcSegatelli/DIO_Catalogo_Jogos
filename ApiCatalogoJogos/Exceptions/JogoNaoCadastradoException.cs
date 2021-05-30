using System;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoException: Exception
    {
        public JogoNaoCadastradoException()
            :base("Ei, esse jogo ainda não está cadastrado :(")
        {}
    }
}
