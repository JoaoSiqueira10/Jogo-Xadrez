using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Tabuleiro tab = new Tabuleiro(8, 8);



                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 9));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
