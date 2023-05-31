using CartagenaServer;
using Sistema_Autonomo.Classes;
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
    public partial class FrmLobby : Form
    {
        Partida partida;
        Jogador jogador;
        public FrmLobby(Partida partida, Jogador jogador)
        {
            InitializeComponent();
            this.Partida = partida;
            this.Jogador = jogador;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Partida Partida { get => partida; set => partida = value; }
        public Jogador Jogador { get => jogador; set => jogador = value; }

        private void FrmLobby_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1400, 800);
            MostraInformacoesJogador();
            ListaJogadores();
        }
        private void ListaJogadores()
        {
            Partida.ListaJogadores = Utils.transformaEmLista(Jogo.ListarJogadores(partida.idPartida));

            Partida.ListaJogadores.ForEach(jogador => lsvListaJogadoresPartida.Items.Add(jogador));
        }
        private void MostraInformacoesJogador()
        {
            lblNomeJogador.Text = jogador.NomeJogador;
            lblIdJogador.Text = jogador.IdJogador.ToString();
            lblCorJogador.Text = jogador.CorJogador;

            if (jogador.CorJogador == "Marrom")
            {
                lblCorJogador.ForeColor = Color.Brown;
            }
            else if (jogador.CorJogador == "Vermelho")
            {
                lblCorJogador.ForeColor = Color.Red;
            }
            else if (jogador.CorJogador == "Amarelo")
            {
                lblCorJogador.ForeColor = Color.Yellow;
            }
            else if (jogador.CorJogador == "Verde")
            {
                lblCorJogador.ForeColor = Color.Green;
            }
            else if (jogador.CorJogador == "Azul")
            {
                lblCorJogador.ForeColor = Color.Blue;
            }
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Jogo.IniciarPartida(jogador.IdJogador, jogador.SenhaJogador);
            bool automatico = false;
            if (chckBoxJogarAutomatico.Checked)
            {
                automatico = true;
            }

            FrmInGame frmIngame = new FrmInGame(partida, jogador, automatico);
            this.Hide();
            TimerAttListaJogadores.Enabled = false;
            frmIngame.ShowDialog();
            TimerAttListaJogadores.Enabled = true;
            this.Show();
        }
        private void TimerAttListaJogadores_Tick(object sender, EventArgs e)
        {
            List<string> listaJogadores = Utils.transformaEmLista(Jogo.ListarJogadores(partida.idPartida));

            foreach (var item in listaJogadores)
            {
                if (!partida.ListaJogadores.Contains(item))
                {
                    partida.ListaJogadores.Add(item);
                    lsvListaJogadoresPartida.Items.Add(item);
                }
            }
        }
        private void btnIniciarPartida_MouseDown(object sender, MouseEventArgs e)
        {
            btnIniciarPartida.BackgroundImage = Properties.Resources.BOTAO_INICIARPARTIDA_BRANCO;
        }
        private void btnIniciarPartida_MouseUp(object sender, MouseEventArgs e)
        {
            btnIniciarPartida.BackgroundImage = Properties.Resources.BOTAO_INICIARPARTIDA_PRETO;
        }
    }

}
