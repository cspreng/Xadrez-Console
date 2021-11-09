using System;
using xadrez;
using tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
            

            Tela.imprimirTabuleiro(partida.tab);
            }
            catch(TabuleiroExcepition e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
