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


            List<string> listaJogadores = Jogo.ListarJogadores(int.Parse(dadosPartidaSelecionada[0]))
                .Replace("\r", "").Split('\n').ToList();

          

           

            Jogador player = new Jogador(idJogador, senhaJogador, corPartida);
            
            
            this.Hide();
            frmPartida partida = new frmPartida(player, int.Parse(dadosPartidaSelecionada[0]));
            partida.ShowDialog();
            partida = null;
            this.Show();

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


       
    }
}


