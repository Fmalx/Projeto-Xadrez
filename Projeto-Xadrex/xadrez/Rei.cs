using System;
using tabuleiro;

namespace xadrez
{
    class Rei:Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podemover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tab.posicaoValida(pos)&&podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna+1);
            if (tab.posicaoValida(pos) && podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //direita
            pos.definirValores(posicao.linha +1, posicao.coluna);
            if (tab.posicaoValida(pos) && podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Suldeste
            pos.definirValores(posicao.linha +1, posicao.coluna+1);
            if (tab.posicaoValida(pos) && podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //So
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //no
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podemover(pos))// se tab posicao for verdadeira e receber poder mover
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
