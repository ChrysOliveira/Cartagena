using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Sistema_Autonomo
{
    public partial class frmInicial : Form
    {
        List<string> listaPartidas;
        List<string> retornoTabuleiro;

        int idJogador, idJogadorRodada;

        string senhaJogador, corPartida;

        string[] dadosPartidaSelecionada;


        public frmInicial()
        {
            InitializeComponent();

            listaPartidas = new List<string>();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            listaPartidas = Jogo.ListarPartidas("T").Replace("\r", "").Split('\n').ToList();

            listaPartidas.ForEach(item => lsbListaPartidas.Items.Add(item));

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            idJogadorRodada = int.Parse(Jogo.IniciarPartida(idJogador, senhaJogador));

            string retorno = Jogo.ConsultarMao(idJogador, senhaJogador);


        }

        private void btnExibirCartasEmMao_Click(object sender, EventArgs e)
        {
            List<string> retorno = Jogo.ConsultarMao(idJogador, senhaJogador)
                .Replace("\r", "").Split('\n').ToList();

            lblCartasNaMao.Text = "";

            foreach (string item in retorno)
            {
                lblCartasNaMao.Text += $"\n{item}";
            }

        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {

            retornoTabuleiro = Jogo.ExibirTabuleiro(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();
      
            CriaMapa();
        }

        private void btnJogadorVez_Click(object sender, EventArgs e)
        {
            List<string> retorno = Jogo.VerificarVez(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();

            lblJogadorVez.Text = "";
            string[] primeirosDados = retorno[0].Split(',');

            lblJogadorVez.Text += $"Status da partida: {primeirosDados[0]}";
            lblJogadorVez.Text += $"\nJogador da vez: {primeirosDados[1]}";
            lblJogadorVez.Text += $"\nNumero da jogada atual: {primeirosDados[2]}";

            int qntElementos = retorno.Count;

            string blabla = retorno[1];

            Console.WriteLine();
            for (int i = 1; i < (retorno.Count - 1); i++)
            {
                string[] situacaoTabuleiro = retorno[i].Split(',');

                lblJogadorVez.Text += $"\nNa posicao: {situacaoTabuleiro[0]} o jogador {situacaoTabuleiro[1]} possui {situacaoTabuleiro[2]} piratas";
            }
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.Jogar(idJogador, senhaJogador);
        }
        private void txbPosicaoRetornar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            List<string> retorno = Jogo.ExibirHistorico(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();

            lblHistorico.Text = "";

            foreach (string item in retorno)
            {
                lblHistorico.Text += $"\n {item}";
            }

        }

        private void btnMoverPirataRetornar_Click(object sender, EventArgs e)
        {
            string retonro = Jogo.Jogar(idJogador, senhaJogador, int.Parse(txbPosicaoRetornar.Text));

        }

        private void btnAvancarPirata_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(idJogador, senhaJogador, int.Parse(txbPosicaoAvancar.Text), txbSimboloAvancar.Text);
        }
        private void btnCriarNovaPartida_Click(object sender, EventArgs e)
        {

            string id = Jogo.CriarPartida(txbNomeNovaPartida.Text, txbSenhaNovaPartida.Text);

            lblIdPartidaCriada.Text += $" {id}";
        }

        private void btnEntrarNaPartida_Click(object sender, EventArgs e)
        {

            dadosPartidaSelecionada = lsbListaPartidas.Text.Split(',');

            string[] retorno = Jogo.EntrarPartida(int.Parse(dadosPartidaSelecionada[0]), txbNomeJogador.Text, txbSenhaPartidaEntrar.Text).Replace("\r", "").Split(',');

            if (retorno[0].StartsWith("ERRO"))
            {
                MessageBox.Show(retorno[0], "Nome Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            idJogador = int.Parse(retorno[0]);
            senhaJogador = retorno[1];
            corPartida = retorno[2];

            lblIdJogadorCriado.Text += $" {idJogador}";
            lblSenhaCriada.Text += $" {senhaJogador}";
            lblCorCriada.Text += $" {corPartida}";

            List<string> listaJogadores = Jogo.ListarJogadores(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();

            listaJogadores.ForEach(jogador => lsvListaJogadoresPartida.Items.Add(jogador));

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private Panel CriaPainel()
        {
            Panel panel = new Panel();
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.Width = 100;
            return panel;
        }

        private void CriaMapa()
        {
            int margemY = 310, margemX = 275;

            int y=0, x=0;

            List<Panel> panelList = new List<Panel>();

            foreach (string item in retornoTabuleiro)
            {
                string[] valores = item.Split(',');
                Panel criado = CriaPainel();
                if (valores[0] == "")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
                else if (valores[1] == "T")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);

                }
                else if (valores[1] == "E")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
                else if (valores[1] == "F")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
                else if (valores[1] == "G")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
                else if (valores[1] == "P")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
                else if (valores[1] == "C")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
                else if (valores[1] == " ")
                {
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
            }

            int direcao = 0;
            int contaDescida = 0;

            for (int i = 0; i < panelList.Count; i++)
            {
                if ((margemX + (x * panelList[i].Width) < this.Width - margemX) && direcao == 0)
                {
                    panelList[i].Top = margemY + (y * panelList[i].Width);
                    panelList[i].Left = margemX + (x * panelList[i].Width);

                    if ((margemX + ((x + 1) * panelList[i].Width) < this.Width - margemX))
                    {
                        x++;
                    }
                    else
                    {
                        contaDescida = 0;
                        direcao = 2;
                    }
                }
                else if (contaDescida < 2 && direcao == 2)
                {
                    panelList[i].Left = margemX + (x * panelList[i].Width);
                    y++;
                    panelList[i].Top = margemY + (y * panelList[i].Width);

                    contaDescida++;

                    if ((margemX + (x * panelList[i].Width) == margemX) && contaDescida == 2)
                    {
                        direcao = 0;
                    }
                    else if ((margemX + (x * panelList[i].Width) < this.Width - margemX) && contaDescida == 2)
                    {
                        direcao = 1;
                    }
                }
                else if ((margemX + (x * panelList[i].Width) >= margemX) && direcao == 1)
                {
                    panelList[i].Top = margemY + (y * panelList[i].Width);

                    if ((margemX + ((x - 1) * panelList[i].Width) > margemX))
                    {
                        x--;
                    }
                    else
                    {
                        x--;
                        contaDescida = 0;
                        direcao = 2;
                    }

                    panelList[i].Left = margemX + (x * panelList[i].Width);

                }

                this.Controls.Add(panelList[i]);
            }
        }
    }
}
