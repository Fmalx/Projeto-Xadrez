using System;
using tabuleiro;

namespace Projeto_Xadrex
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)// precisa do for para percorrer a Matrix 1º for ler linhas e o 2º colunas
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)// se a matriz estiver nulla vai imprimir os -, caso não imprime o valor na posição
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");//acessa o metodo que retorna os valores da matriz
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
