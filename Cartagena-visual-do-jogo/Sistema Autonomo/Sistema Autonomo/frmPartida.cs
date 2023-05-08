using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo
{
    public partial class frmPartida : Form
    {

        Jogador jogador;
        int IdPartida;
        Tabuleiro tabuleiro;
        string CartaSelecionada;
        public frmPartida(Jogador jogador, int IdPartida)
        {
            InitializeComponent();

            this.jogador = jogador;
            this.IdPartida = IdPartida;

        }

        public void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            panelQualquer.Visible = true;

            timer1.Enabled = true;

            int idJogadorRodada = int.Parse(Jogo.IniciarPartida(jogador.Id, jogador.senha));

            List<string> retorno = Jogo.ConsultarMao(jogador.Id, jogador.senha)
                .Replace("\r", "").Split('\n').ToList();

            Cartas.Items.Clear(); // Limpa a lista de cartas na mão

            foreach (string item in retorno)
            {
                Cartas.Items.Add(item); // Adiciona cada carta à lista de cartas na mão
            }
        }

        public void btJogar_Click(object sender, EventArgs e)
        {
            //string retonro = Jogo.Jogar(jogador.Id, jogador.senha, jogador.Piratas.casa);

            
        }

        public void btVoltar_Click(object sender, EventArgs e)
        {

        }

        public void btPular_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.Jogar(jogador.Id, jogador.senha);
        }

        

       


        private void HistoricoPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> retorno = Jogo.ExibirHistorico(IdPartida)
                .Replace("\r", "").Split('\n').ToList();

            HistoricoPartida.Items.Clear(); // Limpa a lista de itens da ListView

            if (retorno[0] == "")
            {

            }
            else
            {
                foreach (string item in retorno)
                {
                
                    string nJogador = item[0].ToString();
                    string nJogada = item[1].ToString();
                    string simbolo = item[2].ToString(); 
                    string origem = item[3].ToString();
                    string destino = item[4].ToString();

                    // Cria um novo item de ListView com a Id do Jogador, N° da jogada, Símbolo, Posição de origem, Posição de Destino
                    ListViewItem novoItem = new ListViewItem(new[] { nJogador, nJogada, simbolo, origem, destino });

                    // Adiciona o novo item à lista de itens da ListView
                    HistoricoPartida.Items.Add(novoItem);
                }
            }
            

        }

       

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            List<string> tab = Jogo.ExibirTabuleiro(IdPartida).Replace("\r", "").Split('\n').ToList();


            List<string> simbolos = new List<string>();

            foreach (string item in tab)
            {
                simbolos.Add(item);
            }
            tabuleiro = new Tabuleiro(simbolos, jogador.Piratas);


            List<string> retorno = Jogo.ExibirTabuleiro(IdPartida)
            .Replace("\r", "").Split('\n').ToList();

            lblTabuleiro.Text = "";

            foreach (string item in retorno)
            {
                lblTabuleiro.Text += $"\n{item}";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           


        }

        private void lblJogadorVez_Click(object sender, EventArgs e)
        {
            
        }

        public void Verificar_Vez()
        {
            List<string> retorno = Jogo.VerificarVez(IdPartida)
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
        private void Atualizar_infos()
        {
            Verificar_Vez();

            btnExibirTabuleiro.PerformClick();

            HistoricoPartida_SelectedIndexChanged(this, EventArgs.Empty);

            btnExibirTabuleiro.PerformClick();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
           Atualizar_infos();
            
            Cartas_SelectedIndexChanged_1(sender, EventArgs.Empty);

            MeusPiratas_SelectedIndexChanged(sender, EventArgs.Empty);
        }

        private void Cartas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<string> retorno = Jogo.ConsultarMao(jogador.Id, jogador.senha)
                .Replace("\r", "").Split('\n').ToList();

            Cartas.Items.Clear(); // Limpa a lista de cartas na mão

            foreach (string item in retorno)
            {
                Cartas.Items.Add(item); // Adiciona cada carta à lista de cartas na mão
            }

            if (Cartas.SelectedItems.Count > 0)
            {
               CartaSelecionada = Cartas.SelectedItem.ToString();
                
            }

            
        }

        private void MeusPiratas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MeusPiratas.Items.Clear();

            foreach (Pirata pirata in jogador.Piratas)
            {
                MeusPiratas.Items.Add($"Pirata {pirata.PosicaoNaLista} - Casa {pirata.Casa}");
            }
        }

       
    }
}
