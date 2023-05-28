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
        private List<int> casasLivres;
        public Partida() {
        
            tabuleiro = new Tabuleiro();
            casasLivres = new List<int> { };
        }

        internal Tabuleiro Tabuleiro { get => tabuleiro; set => tabuleiro = value; }
        public List<string> JogadorDaRodada { get => jogadorDaRodada; set => jogadorDaRodada = value; }
        public List<string> HistoricoPartida { get => historicoPartida; set => historicoPartida = value; }
        public List<string> ListaJogadores { get => listaJogadores; set => listaJogadores = value; }
        public List<int> CasasLivres { get => casasLivres; set => casasLivres = value; }

        public void AtualizaCasasLivres()
        {
            casasLivres.Clear();

            this.tabuleiro.PiratasTabuleiro.ForEach(pirata => { 
            if(pirata.IdJogador == 0 && !casasLivres.Contains(pirata.NumeroDaCasa))
                {
                    casasLivres.Add(pirata.NumeroDaCasa);
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
