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
        public Partida() {
        
            tabuleiro = new Tabuleiro();
        }

        internal Tabuleiro Tabuleiro { get => tabuleiro; set => tabuleiro = value; }
        public List<string> JogadorDaRodada { get => jogadorDaRodada; set => jogadorDaRodada = value; }
        public List<string> HistoricoPartida { get => historicoPartida; set => historicoPartida = value; }
        public List<string> ListaJogadores { get => listaJogadores; set => listaJogadores = value; }
    }
}
