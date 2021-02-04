using System;
using GameTOP.Lib;

namespace GAMETOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFODA(
                new Jogador2(),
                new Jogador1()
            );
            jogo.IniciarJogo();
        }
    }
}
