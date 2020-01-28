using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoDaHora(new jogador2("Ader"),
                                      new Jogador1("Ronaldo"));
            jogo.IniciarJogo();
        }
    }

}
