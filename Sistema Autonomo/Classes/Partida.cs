using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo.Classes
{
    public class Partida
    {   
        public int idPartida;
        private Tabuleiro tabuleiro;
        private List<string> jogadorDaRodada;
        private List<string> historicoPartida;
        private List<string> listaJogadores;
        private List<CasaTabuleiro> casasLivresParaAvancar;

        public Partida() {
        
            tabuleiro = new Tabuleiro();
            casasLivresParaAvancar = new List<CasaTabuleiro> { };
        }

        internal Tabuleiro Tabuleiro { get => tabuleiro; set => tabuleiro = value; }
        public List<string> JogadorDaRodada { get => jogadorDaRodada; set => jogadorDaRodada = value; }
        public List<string> HistoricoPartida { get => historicoPartida; set => historicoPartida = value; }
        public List<string> ListaJogadores { get => listaJogadores; set => listaJogadores = value; }
        public List<CasaTabuleiro> CasasLivresParaAvancar { get => casasLivresParaAvancar; set => casasLivresParaAvancar = value; }

        public void AtualizaCasasLivresParaAvancar()
        {
            casasLivresParaAvancar.Clear();

            this.tabuleiro.CasasDoTabuleiro.ForEach(casa => {

                int piratasLivres = 0;

                if (!casasLivresParaAvancar.Contains(casa))
                {
                    foreach (Pirata pirata in casa.PiratasDaCasa)
                    {
                        if (pirata.IdJogador != 0)
                        {
                            piratasLivres++;
                            break;
                        }
                    }

                    if(piratasLivres == 0 && casa.NumeroCasa != 0 && casa.NumeroCasa != 37)
                    {
                        casasLivresParaAvancar.Add(casa);
                    }
                }
            });
        }
        public void AtualizaJogadorRodada()
        {
            jogadorDaRodada =  Utils.transformaEmLista(Jogo.VerificarVez(this.idPartida));
        }
        public bool verificaVezJogador(int id)
        {
            string [] retorno = Utils.transformaEmLista(Jogo.VerificarVez(this.idPartida)).First().Split(',');
            return int.Parse(retorno[1]) == id;
        }
    }
}
