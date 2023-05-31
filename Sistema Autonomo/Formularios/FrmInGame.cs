using CartagenaServer;
using Sistema_Autonomo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Formularios
{
    public partial class FrmInGame : Form
    {
        private Partida partida;
        private Jogador jogador;
        private bool automatico;

        public FrmInGame(Partida partida, Jogador jogador, bool automatico)
        {
            InitializeComponent();
            this.Partida = partida;
            this.Jogador = jogador;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.automatico = automatico;
        }

        public Partida Partida { get => partida; set => partida = value; }
        public Jogador Jogador { get => jogador; set => jogador = value; }

        private void FrmInGame_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1400, 800);

            Partida.Tabuleiro.ListaTabuleiro = Utils.transformaEmLista(Jogo.ExibirTabuleiro(Partida.idPartida));
            partida.HistoricoPartida = Utils.transformaEmLista(Jogo.ExibirHistorico(partida.idPartida));

            partida.Tabuleiro.CriaMapa(pnlTabuleiro);

            AtualizaJogadorRodada();
            AtualizaListaPiratas();
            AtualizaListaCartas();

            partida.AtualizaCasasLivresParaAvancar();
            jogador.AtualizarMeusPiratas(partida);
            jogador.AtualizarCartasNaMao();
        }
        private void AtualizaJogadorRodada()
        {
            partida.AtualizaJogadorRodada();

            string[] retorno = partida.JogadorDaRodada.First().Split(',');

            lblDadosJogadorRodada.Text = $"Status partida: {retorno[0]} \nJogador da vez: {retorno[1]} \nNº da jogada: {retorno[2]}";

            if (int.Parse(retorno[1]) != jogador.IdJogador)
            {
                lsbPiratasJogadorVez.Enabled = false;
                lsbCartasJogadorVez.Enabled = false;
            }
        }
        private void AtualizaListaPiratas()
        {
            List<string> retorno = Utils.transformaEmLista(Jogo.VerificarVez(partida.idPartida));
            retorno.RemoveAt(0);
            lsbPiratasJogadorVez.Items.Clear();
            retorno.ForEach(item =>
            {
                string[] dados = item.Split(',');
                string informacao = $"Casa: {dados[0]}, tem {dados[2]} Piratas";
                lsbPiratasJogadorVez.Items.Add(informacao);
            });

        }
        private void AtualizaListaCartas()
        {
            List<string> retorno = Utils.transformaEmLista(Jogo.ConsultarMao(jogador.IdJogador, jogador.SenhaJogador));
            lsbCartasJogadorVez.Items.Clear();

            retorno.ForEach(item =>
            {
                string[] dados = item.Split(',');
                string informacao = $"Simbolo: {dados[0]}, Qnt:{dados[1]}";
                lsbCartasJogadorVez.Items.Add(informacao);
            });
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (rdBtnPularVez.Checked)
            {
                jogador.pularJogada(partida);
            }
            else if (rdBtnRetornarPirata.Checked)
            {
                try
                {
                    int posicao = int.Parse(lsbPiratasJogadorVez.Text.Split(',').First().Substring(5));
                    jogador.retornarPirata(posicao, partida);

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Selecione uma posicao", "Problema ao retornar o pirata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                    return;
                }
            }
            else if (rdBtnAvancarPirata.Checked)
            {
                try
                {
                    int posicao = int.Parse(lsbPiratasJogadorVez.Text.Split(',').First().Substring(5));
                    string carta = lsbCartasJogadorVez.Text.Split(',').First().Substring(9);
                    jogador.avancarPirata(posicao, carta,partida);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Selecione uma carta e uma posicao", "Problema ao avancar o pirata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                    return;
                }
            }
        }
        private void TimerAttViewMenus_Tick(object sender, EventArgs e)
        {
            if (rdBtnPularVez.Checked)
            {
                lsbPiratasJogadorVez.Enabled = false;
                lsbCartasJogadorVez.Enabled = false;
            }
            else if (rdBtnRetornarPirata.Checked)
            {
                lsbCartasJogadorVez.Enabled = false;
            }
            else if (rdBtnAvancarPirata.Checked)
            {
                lsbPiratasJogadorVez.Enabled = true;
                lsbCartasJogadorVez.Enabled = true;
            }
        }
        private void TimerAttDadosTela_Tick(object sender, EventArgs e)
        {
            if (!partida.verificaVezJogador(jogador.IdJogador))
            {
                partida.Tabuleiro.AtualizaPiratasNoMapa(partida);
                AtualizaJogadorRodada();
            }
        }
        private void btnJogar_MouseDown(object sender, MouseEventArgs e)
        {
            btnJogar.BackgroundImage = Properties.Resources.BOTAO_JOGAR_BRANCO;
        }
        private void btnJogar_MouseUp(object sender, MouseEventArgs e)
        {
            btnJogar.BackgroundImage = Properties.Resources.BOTAO_JOGAR_PRETO;

        }
        private void TimerRealizaJogada_Tick(object sender, EventArgs e)
        {
            string retorno = "";
            if (partida.verificaVezJogador(jogador.IdJogador) && automatico == true)
            {
                if (jogador.MeusPiratas.Count < 6)
                {
                    retorno = jogador.avancoInicial(partida);
                    AtualizaJogadorRodada();
                }
                else if (jogador.CartasNaMao.Count < 1)
                {
                    retorno = jogador.realizaCompra(partida);
                    retorno = jogador.avancarPirataMaisAtrasado(partida);
                    AtualizaJogadorRodada();
                }
                else
                {
                    retorno = jogador.avancarPirataMaisAtrasado(partida);
                    AtualizaJogadorRodada();
                }
                AtualizaListaCartas();
                AtualizaListaPiratas();
                if (retorno.StartsWith("ERRO:Partida não está em jogo"))
                {
                    MessageBox.Show(retorno, "Problema ao realizar jogada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TimerRealizaJogada.Stop();
                    return;
                }
            }
        }
    }
}
