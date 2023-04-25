using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Formularios
{
    public partial class FrmInGame : FrmTemplate
    {
        Partida partida;
        Jogador jogador;
        public FrmInGame(Partida partida, Jogador jogador)
        {
            InitializeComponent();
            this.partida = partida;
            this.jogador = jogador;
        }

        private void btnExibirCartasEmMao_Click(object sender, EventArgs e)
        {
            AtualizaMaoJogador();
        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            ExibirTabuleiro();
        }

        private void btnJogadorVez_Click(object sender, EventArgs e)
        {
            ExibirJogadorDaRodada();
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.Jogar(jogador.Id, jogador.Senha);
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            partida.HistoricoJogadas = Jogo.ExibirHistorico(partida.Id)
                .Replace("\r", "").Split('\n').ToList();
        }

        /*private void btnMoverPirataRetornar_Click(object sender, EventArgs e)
        {
            string retonro = Jogo.Jogar(jogador.Id, jogador.Senha, int.Parse(txbPosicaoRetornar.Text));

        }

        private void btnAvancarPirata_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(jogador.Id, jogador.Senha, int.Parse(txbPosicaoAvancar.Text), txbSimboloAvancar.Text);
        }*/
        private void AtualizaMaoJogador()
        {
            jogador.MaoAtual = Jogo.ConsultarMao(jogador.Id, jogador.Senha)
                        .Replace("\r", "").Split('\n').ToList();

            foreach (string item in jogador.MaoAtual)
            {
                lblCartasNaMao.Text += $"\n{item}";
            }
        }

        private void ExibirTabuleiro()
        {
            partida.Tabuleiro = Jogo.ExibirTabuleiro(partida.Id)
                .Replace("\r", "").Split('\n').ToList();
        }

        private void ExibirJogadorDaRodada()
        {
            partida.JogadorDaRodada = Jogo.VerificarVez(partida.Id)
                .Replace("\r", "").Split('\n').ToList();


            lblJogadorVez.Text = "";
            lblJogadorVez.Text += $"Status da partida: {partida.JogadorDaRodada[0].Split(',').ElementAt(0)}";
            lblJogadorVez.Text += $"\nJogador da vez: {partida.JogadorDaRodada[0].Split(',').ElementAt(1)}";
            lblJogadorVez.Text += $"\nNumero da jogada atual: {partida.JogadorDaRodada[0].Split(',').ElementAt(2)}";


            Console.WriteLine();
            for (int i = 1; i < (partida.JogadorDaRodada.Count - 1); i++)
            {
                string[] situacaoTabuleiro = partida.JogadorDaRodada[i].Split(',');

                lblJogadorVez.Text += $"\nNa posicao: {situacaoTabuleiro[0]} o jogador {situacaoTabuleiro[1]} possui {situacaoTabuleiro[2]} piratas";
            }
        }

    }

}
