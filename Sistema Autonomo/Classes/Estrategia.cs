using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo.Classes
{
    internal class Estrategia
    {
        List<Jogador> jogadores;
        Tabuleiro tabuleiro;
        Jogador MeuJogador;

        public Estrategia(Tabuleiro tabuleiro, List<Jogador> jogadores, List<int> ID, List<string> cor, Jogador MeuJogador, int Id, string Senha, string Cor)
        {
            this.tabuleiro = tabuleiro;
            jogadores = new List<Jogador>();
            MeuJogador = new Jogador(Id, Senha, Cor);
            this.MeuJogador = MeuJogador;

            for (int i = 0; i < ID.Count; i++)
            {
                Jogador jogador = new Jogador(ID[i], cor[i]);
                jogadores.Add(jogador);
            }
        }
        public Estrategia


        public void JogarSemEstrategia()
        {
            int pirataEscolhido = PirataAtrasado(MeuJogador.Id());
            string cartaEscolhida = EscolherCarta(MeuJogador.Id());
            Jogo.Jogar(MeuJogador.Id(), MeuJogador.Senha(), pirataEscolhido, cartaEscolhida);
        }

        private int PirataAtrasado(int id)
        {
            int meusPiratas;
            int casa;
            int aux;
            for (int i = 0; i < 6; i++)
            {
                meusPiratas =
                jogadores[id].PirataCasa(i);

                if (i != 6)
                {
                    casa = jogadores[id].PirataCasa(i + 1);
                    if (casa > meusPiratas)
                    {
                        aux = meusPiratas;
                    }
                    else
                    {
                        aux = casa;
                    }
                }

            }
            return aux;
        }

        private string EscolherCarta(int id)
        {
            string carta;

            carta = jogadores[id].EscolherCarta();


            return carta;
        }
    }
}
