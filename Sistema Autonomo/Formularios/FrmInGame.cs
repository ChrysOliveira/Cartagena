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
    public partial class FrmInGame : FrmModelo
    {
        Partida partida;
        Jogador jogador;
        Tabuleiro tabuleiro;

        int margemY = 10, margemX = 10;

        public Partida Partida { get => partida; set => partida = value; }
        public Jogador Jogador { get => jogador; set => jogador = value; }
        public FrmInGame(Partida partida, Jogador jogador)
        {
            InitializeComponent();
            this.Partida = partida;
            this.Jogador = jogador;
            tabuleiro= new Tabuleiro();
        }
        private void FrmInGame_Load(object sender, EventArgs e)
        {
            Partida.Tabuleiro.ListaTabuleiro = Utils.transformaEmLista(Jogo.ExibirTabuleiro(Partida.idPartida));
            partida.HistoricoPartida = Utils.transformaEmLista(Jogo.ExibirHistorico(partida.idPartida));
            
            tabuleiro.CriaMapa(pnlTabuleiro); //agora é uma função de tabuleiro e precisa passar o parametro do painel 

            AtualizaJogadorRodada();
            AtualizaListaPiratas();
            AtualizaListaCartas();
            AtualizaPiratasNoMapa();
        }
        
        private void AtualizaJogadorRodada()
        {
            string[] retorno = Utils.transformaEmLista(Jogo.VerificarVez(partida.idPartida)).First().Split(',');

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
                string informacao = $"Casa: {dados[0]}, Qnt Piratas:{dados[2]}";
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
        private void DefineCorDoPirata(Pirata pirata)
        {
            if (pirata.CorPirata == "Marrom")
            {
                pirata.BackgroundImage = Properties.Resources.MARROM;
            }
            else if (pirata.CorPirata == "Vermelho")
            {
                pirata.BackgroundImage = Properties.Resources.VERMELHO;
            }
            else if (pirata.CorPirata == "Amarelo")
            {
                pirata.BackgroundImage = Properties.Resources.AMARELO;
            }
            else if (pirata.CorPirata == "Verde")
            {
                pirata.BackgroundImage = Properties.Resources.VERDE;
            }
            else if (pirata.CorPirata == "Azul")
            {
                pirata.BackgroundImage = Properties.Resources.AZUL;
            }
        }
        private void AtualizaPiratasNoMapa()
        {
            List<string> diferencaHistorico = Utils.transformaEmLista(Jogo.ExibirHistorico(partida.idPartida));
            RetornoPiratas();

            foreach (var historicoItem in diferencaHistorico)
            {
                if (!partida.HistoricoPartida.Contains(historicoItem))
                {
                    string[] dados = historicoItem.Split(',');

                    if (dados[2] == "" && dados[3] == "")
                    {
                        continue;
                    }
                    else if (dados[3] != "")
                        {
                        int casaDeleta = int.Parse(dados[3]);
                        int casaAtribui = int.Parse(dados[4]);

                        foreach (var pirata in partida.Tabuleiro.CasasDoTabuleiro[casaDeleta].PiratasDaCasa)
                            {
                                    if (pirata.IdJogador == int.Parse(dados[0]))
                                    {
                                        pirata.IdJogador = 0;
                                        pirata.CorPirata = null;
                                        pirata.Visible = false;
                                break;
                                    }
                            }

                        foreach (var pirata in partida.Tabuleiro.CasasDoTabuleiro[casaAtribui].PiratasDaCasa)
                                {
                                    if (pirata.IdJogador == 0)
                                    {
                                        pirata.IdJogador = int.Parse(dados[0]);
                                        string[] dadosJogador = partida.ListaJogadores.Find(jogador => jogador.StartsWith(dados[0])).Split(',');
                                        pirata.CorPirata = dadosJogador[2];
                                        DefineCorDoPirata(pirata);
                                        pirata.Visible = true;
                                        break;
                                    }
                                }
                            }
                    partida.HistoricoPartida.Add(historicoItem);
                }
            }
        }

        public List<string> RetornoPiratas()
        {
            List<string> dados = new List<string>();
            dados = Utils.transformaEmLista(Jogo.VerificarVez(partida.idPartida));

            dados.Remove(dados[0]);
            dados.Remove(dados[1]);
            dados.Remove(dados[2]);
            return dados;

            
        }


        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (rdBtnPularVez.Checked)
            {
                Jogo.Jogar(jogador.IdJogador, jogador.SenhaJogador);
            }
            else if (rdBtnRetornarPirata.Checked)
            {
                int posicao = int.Parse(lsbPiratasJogadorVez.Text.Split(',').First().Substring(5));

                Jogo.Jogar(jogador.IdJogador, jogador.SenhaJogador, posicao);
            }
            else if (rdBtnAvancarPirata.Checked)
            {
                int posicao = int.Parse(lsbPiratasJogadorVez.Text.Split(',').First().Substring(5));
                string carta = lsbCartasJogadorVez.Text.Split(',').First().Substring(9);
                Jogo.Jogar(jogador.IdJogador, jogador.SenhaJogador, posicao, carta);
            }
            
            AtualizaJogadorRodada();
            AtualizaListaCartas();
            AtualizaListaPiratas();
            AtualizaPiratasNoMapa();
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
            AtualizaPiratasNoMapa();
        }
    }
}
