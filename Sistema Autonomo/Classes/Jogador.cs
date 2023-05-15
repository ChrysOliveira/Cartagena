using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo.Classes
{
    public class Jogador
    {
        private int idJogador;
        private string senhaJogador;
        private string corJogador;
        private List<string> cartasNaMao;

        public Jogador()
        {
        }

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string SenhaJogador { get => senhaJogador; set => senhaJogador = value; }
        public string CorJogador { get => corJogador; set => corJogador = value; }
        public List<string> CartasNaMao { get => cartasNaMao; set => cartasNaMao = value; }
    }
}
