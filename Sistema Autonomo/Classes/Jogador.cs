using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sistema_Autonomo.Classes
{
    public class Jogador
    {
        private int idJogador;
        private string nomeJogador;
        private string senhaJogador;
        private string corJogador;
        private List<string> cartasNaMao;
        private List<Pirata> meusPiratas;

        public Jogador()
        {
            cartasNaMao = new List<string>();
            MeusPiratas = new List<Pirata>();
        }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string SenhaJogador { get => senhaJogador; set => senhaJogador = value; }
        public string CorJogador { get => corJogador; set => corJogador = value; }
        public List<string> CartasNaMao { get => cartasNaMao; set => cartasNaMao = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public List<Pirata> MeusPiratas { get => meusPiratas; set => meusPiratas = value; }

        public void pularJogada(Partida partida)
        {
            Jogo.Jogar(this.idJogador, this.senhaJogador);
            partida.Tabuleiro.AtualizaPiratasNoMapa(partida);
            this.AtualizarMeusPiratas(partida);
            this.AtualizarCartasNaMao();
        }
        public void retornarPirata(int posicao, Partida partida)
        {
            Jogo.Jogar(this.idJogador, this.senhaJogador, posicao);
            partida.Tabuleiro.AtualizaPiratasNoMapa(partida);
            this.AtualizarMeusPiratas(partida);
            this.AtualizarCartasNaMao();
            partida.AtualizaCasasLivresParaAvancar();
        }
        public void avancarPirata(int posicao, string carta, Partida partida)
        {
            Jogo.Jogar(this.idJogador, this.senhaJogador, posicao, carta);
            partida.Tabuleiro.AtualizaPiratasNoMapa(partida);
            this.AtualizarMeusPiratas(partida);
            this.AtualizarCartasNaMao();
            partida.AtualizaCasasLivresParaAvancar();
        }
        public void AtualizarCartasNaMao()
        {
            this.CartasNaMao.Clear();
            List<string> retorno = Utils.transformaEmLista(Jogo.ConsultarMao(this.IdJogador, this.SenhaJogador));

            retorno.ForEach(carta =>
            {
                string[] dados = carta.Split(',');

                for (int i = 0; i < int.Parse(dados[1]); i++)
                {
                    this.CartasNaMao.Add(dados[0]);
                }
            });

        }
        public void AtualizarMeusPiratas(Partida partida)
        {
            this.MeusPiratas.Clear();

            partida.Tabuleiro.PiratasTabuleiro.ForEach(pirata =>
            {
                if (pirata.IdJogador == this.IdJogador)
                {
                    this.MeusPiratas.Add(pirata);
                }
            });
        }
        public Pirata pirataMaisAtrasado()
        {
            Pirata pirata = MeusPiratas.First();

            MeusPiratas.ForEach(p =>
            {
                if (p.NumeroDaCasa < pirata.NumeroDaCasa)
                {
                    pirata = p;
                }
            });

            return pirata;
        }
        public void avancoInicial(Partida partida)
        {
            this.avancarPirata(0, cartasNaMao.FirstOrDefault(), partida);
        }
        public void realizaCompra(Partida partida)
        {
            Pirata primeiro, segundo;
            primeiro = meusPiratas.First();
            segundo = meusPiratas.Last();

            this.meusPiratas.ForEach((p) =>
            {
                if (p.NumeroDaCasa > primeiro.NumeroDaCasa)
                {
                    segundo = primeiro;
                    primeiro = p;
                }
            });

            this.retornarPirata(segundo.NumeroDaCasa, partida);
            this.retornarPirata(primeiro.NumeroDaCasa, partida);
            this.AtualizarCartasNaMao();
        }
        public string melhorCartaParaAvancarOPirata(Pirata pirata, Partida partida)
        {
            string melhorCarta = "";
            int distancia = 0;

            foreach (String carta in this.cartasNaMao)
            {
                int achou = 0;
                foreach (CasaTabuleiro casa in partida.CasasLivresParaAvancar)
                {
                    if (casa.NumeroCasa > pirata.NumeroDaCasa && casa.Simbolo == carta)
                    {
                        achou = 1;
                        int auxDistancia = casa.NumeroCasa - pirata.NumeroDaCasa;
                        if (auxDistancia > distancia)
                        {
                            melhorCarta = carta;
                            distancia = auxDistancia;
                            break;
                        }
                    }
                }
                if (achou == 0)
                {
                    melhorCarta = carta;
                    break;
                }
            }

            return melhorCarta;
        }
        public void avancarPirataMaisAtrasado(Partida partida)
        {
            Pirata pirata = this.pirataMaisAtrasado();

            this.avancarPirata(pirata.NumeroDaCasa, melhorCartaParaAvancarOPirata(pirata, partida), partida);
        }
    }
}
