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

        int margemY = 10, margemX = 10;

        public Partida Partida { get => partida; set => partida = value; }
        public Jogador Jogador { get => jogador; set => jogador = value; }
        public FrmInGame(Partida partida, Jogador jogador)
        {
            InitializeComponent();
            this.Partida = partida;
            this.Jogador = jogador;
        }
        private void FrmInGame_Load(object sender, EventArgs e)
        {
            Partida.Tabuleiro.ListaTabuleiro = Utils.transformaEmLista(Jogo.ExibirTabuleiro(Partida.idPartida));
            partida.HistoricoPartida = Utils.transformaEmLista(Jogo.ExibirHistorico(partida.idPartida));

            CriaMapa();
            AtualizaJogadorRodada();
            AtualizaListaPiratas();
            AtualizaListaCartas();
        }
        private void CriaPiratasNaCasa(CasaTabuleiro casa)
        {
            for (int i = 0; i < 3; i++)
            {
                Pirata pirata = new Pirata();
                pirata.BackgroundImageLayout = ImageLayout.Stretch;
                pirata.Width = 20;
                pirata.Height = 20;
                if (i == 0)
                {
                    pirata.Location = new Point(20, casa.Height - 40);
                }
                else if (i == 1)
                {
                    pirata.Location = new Point(40, 20);
                }
                else if (i == 2)
                {
                    pirata.Location = new Point(casa.Width - 40, casa.Height - 40);
                }

                casa.PiratasDaCasa.Add(pirata);
                pirata.NumeroDaCasa = casa.NumeroCasa;
                pirata.BringToFront();
                pirata.Visible = false;
                partida.Tabuleiro.PiratasTabuleiro.Add(pirata);
                casa.Controls.Add(pirata);
            }
        }
        private CasaTabuleiro CriaCasa(int id)
        {
            CasaTabuleiro casa = new CasaTabuleiro(id);
            casa.BackgroundImageLayout = ImageLayout.Stretch;
            casa.Width = 100;
            casa.Height = 100;
            CriaPiratasNaCasa(casa);
            return casa;
        }
        private void DefineSimbolos()
        {
            int id = 0;

            foreach (string item in Partida.Tabuleiro.ListaTabuleiro)
            {
                string[] valores = item.Split(',');

                CasaTabuleiro novaCasa = CriaCasa(id);

                if (valores[1] == "T")
                {
                    novaCasa.BackgroundImage = Properties.Resources.CHAPEU;
                }
                else if (valores[1] == "E")
                {
                    novaCasa.BackgroundImage = Properties.Resources.CAVEIRA;
                }
                else if (valores[1] == "F")
                {
                    novaCasa.BackgroundImage = Properties.Resources.ADAGA;
                }
                else if (valores[1] == "G")
                {
                    novaCasa.BackgroundImage = Properties.Resources.GARRAFA;
                }
                else if (valores[1] == "P")
                {
                    novaCasa.BackgroundImage = Properties.Resources.PISTOLAS;
                }
                else if (valores[1] == "C")
                {
                    novaCasa.BackgroundImage = Properties.Resources.CHAVE;
                }
                else if (valores[1] == " " && valores[0] == "37")
                {
                    novaCasa.BackgroundImage = Properties.Resources.BARCO;
                }
                else if (valores[1] == " " && valores[0] == "0")
                {
                    novaCasa.BackgroundImage = Properties.Resources.FUNDO;
                }
                id++;
                Partida.Tabuleiro.CasasDoTabuleiro.Add(novaCasa);
            }
        }
        private void DefinePosicoes()
        {
            int direcao = 0;
            int contaDescida = 0;
            int y = 0, x = 0;

            for (int i = 0; i < partida.Tabuleiro.CasasDoTabuleiro.Count; i++)
            {
                if ((margemX + (x * partida.Tabuleiro.CasasDoTabuleiro[i].Width) < pnlTabuleiro.Width - margemX) && direcao == 0)
                {
                    partida.Tabuleiro.CasasDoTabuleiro[i].Top = margemY + (y * partida.Tabuleiro.CasasDoTabuleiro[i].Width);
                    partida.Tabuleiro.CasasDoTabuleiro[i].Left = margemX + (x * partida.Tabuleiro.CasasDoTabuleiro[i].Width);

                    if ((margemX + ((x + 1) * partida.Tabuleiro.CasasDoTabuleiro[i].Width) < pnlTabuleiro.Width - margemX))
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
                    partida.Tabuleiro.CasasDoTabuleiro[i].Left = margemX + (x * partida.Tabuleiro.CasasDoTabuleiro[i].Width);
                    y++;
                    partida.Tabuleiro.CasasDoTabuleiro[i].Top = margemY + (y * partida.Tabuleiro.CasasDoTabuleiro[i].Width);

                    contaDescida++;

                    if ((margemX + (x * partida.Tabuleiro.CasasDoTabuleiro[i].Width) == margemX) && contaDescida == 2)
                    {
                        direcao = 0;
                        x++;
                    }
                    else if ((margemX + (x * partida.Tabuleiro.CasasDoTabuleiro[i].Width) < pnlTabuleiro.Width - margemX) && contaDescida == 2)
                    {
                        direcao = 1;
                    }
                }
                else if ((margemX + (x * partida.Tabuleiro.CasasDoTabuleiro[i].Width) >= margemX) && direcao == 1)
                {
                    partida.Tabuleiro.CasasDoTabuleiro[i].Top = margemY + (y * partida.Tabuleiro.CasasDoTabuleiro[i].Width);

                    if ((margemX + ((x - 1) * partida.Tabuleiro.CasasDoTabuleiro[i].Width) > margemX))
                    {
                        x--;
                    }
                    else
                    {
                        x--;
                        contaDescida = 0;
                        direcao = 2;
                    }

                    partida.Tabuleiro.CasasDoTabuleiro[i].Left = margemX + (x * partida.Tabuleiro.CasasDoTabuleiro[i].Width);
                }
                pnlTabuleiro.Controls.Add(partida.Tabuleiro.CasasDoTabuleiro[i]);
            }
        }
        private void CriaMapa()
        {
            DefineSimbolos();
            DefinePosicoes();
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
