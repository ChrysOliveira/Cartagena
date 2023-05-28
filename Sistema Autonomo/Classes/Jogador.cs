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

        public Jogador()
        {
        }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string SenhaJogador { get => senhaJogador; set => senhaJogador = value; }
        public string CorJogador { get => corJogador; set => corJogador = value; }
        public List<string> CartasNaMao { get => cartasNaMao; set => cartasNaMao = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }

        public void pularJogada()
        {
            Jogo.Jogar(this.idJogador, this.senhaJogador);
        }
        public void retornarPirata(int posicao)
        {
            Jogo.Jogar(this.idJogador, this.senhaJogador, posicao);
        }
        public void avancarPirata(int posicao, string carta)
        {
            Jogo.Jogar(this.idJogador, this.senhaJogador, posicao, carta);
        }
    }
}
