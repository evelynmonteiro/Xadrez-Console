using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{

                Tabuleiro tab = new Tabuleiro(8,8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2,4));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3,6));
                Tela.imprimirTabuleiro(tab);
                Console.ReadLine();
            }
            catch(TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}