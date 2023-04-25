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

namespace Sistema_Autonomo.Formularios
{
    public partial class FrmInicial : FrmTemplate
    {
        Jogador jogador;
        Partida partida;
        
        public FrmInicial() 
        {
            InitializeComponent();

        }
         
        private void btnCriarNovaPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txbNomeNovaPartida.Text, txbSenhaNovaPartida.Text);
            
            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Ja existe uma partida com este nome", "Problema ao criar partida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                lblIdPartidaCriada.Text += $" {retorno}";
            }

        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            List<string> listaPartidas = Jogo.ListarPartidas("T").Replace("\r","").Split('\n').ToList();

            listaPartidas.ForEach(item => lsbListaPartidas.Items.Add(item));

        }

        private void btnEntrarNaPartida_Click(object sender, EventArgs e)
        {

            string[] dadosPartidaSelecionada = lsbListaPartidas.Text.Split(',');

            string[] retorno = Jogo.EntrarPartida(int.Parse(dadosPartidaSelecionada[0]), txbNomeJogador.Text, txbSenhaPartidaEntrar.Text)
                .Replace("\r", "").Split(',');

            jogador = new Jogador();
            jogador.Id = int.Parse(retorno[0]);
            jogador.Senha = retorno[1];
            jogador.Cor = retorno[2];

            partida = new Partida();
            partida.Id = int.Parse(dadosPartidaSelecionada[0]);


            FrmLobby frmLobby = new FrmLobby(partida, jogador);
            frmLobby.Show();
            
        }
    }
}
