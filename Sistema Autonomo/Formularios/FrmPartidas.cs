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
using Sistema_Autonomo.Classes;

namespace Sistema_Autonomo.Formularios
{
    public partial class FrmPartidas : Form
    {
        private Partida partida;
        private Jogador jogador;
        private List<string> listaPartidas;
        
        public Partida Partida { get => partida; set => partida = value; }
        public Jogador Jogador { get => jogador; set => jogador = value; }

        public FrmPartidas()
        {
            InitializeComponent();

            listaPartidas = new List<string>();
            this.Partida = new Partida();
            this.Jogador = new Jogador();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FrmInicial_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1400, 800);
            listaPartidas = Utils.transformaEmLista(Jogo.ListarPartidas("T"));
            listaPartidas.ForEach(item => lsbListaPartidas.Items.Add(item));
        }
        private void btnCriarNovaPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txbNomeNovaPartida.Text, txbSenhaNovaPartida.Text);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno, "Problema ao criar partida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnEntrarNaPartida_Click(object sender, EventArgs e)
        {
            string[] dadosPartidaSelecionada = lsbListaPartidas.Text.Split(',');
            string[] retorno = Jogo.EntrarPartida(int.Parse(dadosPartidaSelecionada[0]), txbNomeJogador.Text, txbSenhaPartidaEntrar.Text).Replace("\r", "").Split(',');

            if (retorno[0].StartsWith("ERRO"))
            {
                MessageBox.Show(retorno[0], "Problema ao entrar na partida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                partida.idPartida = int.Parse(dadosPartidaSelecionada[0]);
                Jogador.IdJogador = int.Parse(retorno[0]);
                Jogador.NomeJogador = txbNomeJogador.Text;
                Jogador.SenhaJogador = retorno[1];
                Jogador.CorJogador = retorno[2].Trim('\n');

                FrmLobby frmLobby = new FrmLobby(partida, jogador);
                this.Hide();
                TimerAttListaPartidas.Enabled = false;
                frmLobby.ShowDialog();
                TimerAttListaPartidas.Enabled = true;
                this.Show();
            }
        }
        private void TimerAttListaPartidas_Tick(object sender, EventArgs e)
        {
            List<string> listaPartidasAtt = Utils.transformaEmLista(Jogo.ListarPartidas("T"));

            foreach (var item in listaPartidasAtt)
            {
                if (!listaPartidas.Contains(item))
                {
                    listaPartidas.Add(item);
                    lsbListaPartidas.Items.Add(item);
                }
            }
        }

        private void btnCriarNovaPartida_MouseDown(object sender, MouseEventArgs e)
        {
            btnCriarNovaPartida.BackgroundImage = Properties.Resources.BOTAO_CRIAR_BRANCO;
        }

        private void btnCriarNovaPartida_MouseUp(object sender, MouseEventArgs e)
        {
            btnCriarNovaPartida.BackgroundImage = Properties.Resources.BOTAO_CRIAR_PRETO;
        }

        private void btnEntrarNaPartida_MouseDown(object sender, MouseEventArgs e)
        {
            btnEntrarNaPartida.BackgroundImage = Properties.Resources.BOTAO_ENTRAR_BRANCO;
        }

        private void btnEntrarNaPartida_MouseUp(object sender, MouseEventArgs e)
        {
            btnEntrarNaPartida.BackgroundImage = Properties.Resources.BOTAO_ENTRAR_PRETO;
        }
    }
}
