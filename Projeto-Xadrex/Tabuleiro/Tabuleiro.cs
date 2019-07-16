namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;//Matriz de pecas privadas

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];// inicia a matriz
        }

        public Peca peca(int linha, int coluna)// como a matriz pecas é privada é feito um metodo para que retorne a matriz.
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)// coloca a peça no tabuleiro
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao=pos;
        }
    }
}
