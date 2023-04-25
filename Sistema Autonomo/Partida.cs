using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo
{
    public class Partida
    {
        private int id;

        private List<string> jogadorDaRodada;

        private List<string> jogadorList;

        private List<string> tabuleiro;

        private List<string> historicoJogadas;

        public int Id { get; set; }
        public List<string> JogadorList { get => jogadorList; set => jogadorList = value; }
        public List<string> JogadorDaRodada { get => jogadorDaRodada; set => jogadorDaRodada = value; }
        public List<string> Tabuleiro { get => tabuleiro; set => tabuleiro = value; }
        public List<string> HistoricoJogadas { get => historicoJogadas; set => historicoJogadas = value; }
    }
}
