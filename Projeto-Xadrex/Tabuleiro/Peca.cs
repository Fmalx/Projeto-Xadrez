﻿
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }//associacao com a classe Posicao. - So pode ser alterada por ela mesma e pelas subClasses
        public Cor cor { get; protected set; }//Possui Cores, do tipo enum. - So pode ser alterada por ela mesma e pelas subClasses
        public int qteMovimentos { get; protected set; }//So pode ser alterada por ela mesma e pelas subClasses
        public Tabuleiro tab { get; protected set; }//So pode ser alterada por ela mesma e pelas subClasses

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            qteMovimentos = 0;// iniciada com 0 pois ela ainda nao possui movimentos

        }
    }
}