using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CartagenaServer;

namespace Sistema_Autonomo
{
    public partial class frmInicial : Form
    {
        List<string> listaPartidas;

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

            List<string> retorno = Jogo.ExibirTabuleiro(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();

            lblTabuleiro.Text = "";

            foreach (string item in retorno)
            {
                lblTabuleiro.Text += $"\n{item}";
            }

        }

        private void btnJogadorVez_Click(object sender, EventArgs e)
        {
            /*List<string> retorno = Jogo.VerificarVez(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();

            lbl.Text = "";
            string[] primeirosDados = retorno[0].Split(',');

            lblMostrarVez.Text += $"Status da partida: {primeirosDados[0]}";
            lblMostrarVez.Text += $"\nJogador da vez: {primeirosDados[1]}";
            lblMostrarVez.Text += $"\nNumero da jogada atual: {primeirosDados[2]}";

            int qntElementos = retorno.Count;

            string blabla = retorno[1];

            Console.WriteLine();
            for (int i = 1; i < (retorno.Count - 1); i++)
            {
                string[] situacaoTabuleiro = retorno[i].Split(',');

                lblMostrarVez.Text += $"\nNa posicao: {situacaoTabuleiro[0]} o jogador {situacaoTabuleiro[1]} possui {situacaoTabuleiro[2]} piratas";
            }*/


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




        //cliquei duas vezes sem querer, nao sei apagar sem dar erro
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PainelLoob_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIdPartidaCriada_Click(object sender, EventArgs e)
        {

        }

        private void txbNomeNovaPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblInfoAcoes_Click(object sender, EventArgs e)
        {

        }

        private void lblCartasNaMao_Click(object sender, EventArgs e)
        {

        }

        private void Controles_Cris_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

            PainelLoob.Visible = true;


            this.Hide();
            Partida partida = new Partida();
            partida.ShowDialog();
            partida = null;
            this.Show();

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            idJogadorRodada = int.Parse(Jogo.IniciarPartida(idJogador, senhaJogador));

            string retorno = Jogo.ConsultarMao(idJogador, senhaJogador);

            painelJogo.Visible = true;


        }

        private void exibeVez_Click(object sender, EventArgs e)
        {
            //label de exibir o jogador da vez, tem que atualizar a cada jogada
            /*string[] retorno = new string[];
            lblJogadorVez.Text = "";
            string[] primeirosDados = retorno[0].Split(',');

            lblJogadorVez.Text += $"\nJogador da vez: {primeirosDados[1]}";
            lblJogadorVez.Text += $"\nNumero da jogada atual: {primeirosDados[2]}";

            int qntElementos = retorno.Count;

            string blabla = retorno[1];

            Console.WriteLine();
            for (int i = 1; i < (retorno.Count - 1); i++)
            {
                string[] situacaoTabuleiro = retorno[i].Split(',');

                lblJogadorVez.Text += $"\nNa posicao: {situacaoTabuleiro[0]} o jogador {situacaoTabuleiro[1]} possui {situacaoTabuleiro[2]} piratas";
            }*/


        }

        

        private void Cartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aqui vai selecionar a carta para jogar
        }

        private void piratas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aqui vai selecionar os piratas

        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            //pega o pirata e carta e avança

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            //pega o pirata e volta

        }



        private void btnCriarNovaPartida_Click(object sender, EventArgs e)
        {

            string id = Jogo.CriarPartida(txbNomeNovaPartida.Text, txbSenhaNovaPartida.Text);

            lblIdPartidaCriada.Text += $" {id}";
        }

        private void Jogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //jogadores da partida
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //falta algo para atualizar sozinho o historico das jogadas



            List<string> retorno = Jogo.ExibirHistorico(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();

            lblHistorico.Text = "";

            foreach (string item in retorno)
            {
                listView1.Text += $"\n {item}";
            }
        }

        

        private void btnAvancarPirata_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(idJogador, senhaJogador, int.Parse(txbPosicaoAvancar.Text), txbSimboloAvancar.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btPular_Click(object sender, EventArgs e)
        {
            //pular a vez
            string retorno = Jogo.Jogar(idJogador, senhaJogador);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
    }
}


