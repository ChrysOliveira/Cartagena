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
    public partial class FrmLobby : FrmTemplate
    {
        Partida partida;
        Jogador jogador;
        public FrmLobby(Partida partida, Jogador jogador)
        {
            InitializeComponent();
            this.partida = partida;
            this.jogador = jogador;
        }
        private void FrmLobby_Load(object sender, EventArgs e)
        {
            MostrarListaDeJogadores();
            MostrarDadosDoJogador();
        }

        private void MostrarListaDeJogadores()
        {
            partida.JogadorList = Jogo.ListarJogadores(partida.Id)
               .Replace("\r", "").Split('\n').ToList();

            partida.JogadorList.ForEach(dadosJogador => lsvListaJogadoresPartida.Items.Add(dadosJogador));
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            FrmInGame frmInGame = new FrmInGame(partida, jogador);
            frmInGame.Show();
        }

        private void MostrarDadosDoJogador()
        {
            lblIdJogadorCriado.Text += jogador.Id.ToString();
            lblSenhaCriada.Text += jogador.Senha;
            lblCorCriada.Text += jogador.Cor;
        }

    }
}
