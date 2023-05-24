    using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Classes
{
    internal class Tabuleiro
    {
        private int posicaoX, posicaoY;
        //tamanho do paineol no FrmInGame
        static int width = 1120;
        static int heigth = 737;

        private List<string> listaTabuleiro;
        private List<CasaTabuleiro> casasDoTabuleiro;
        private List<Pirata> piratasTabuleiro;

        int margemY = 10, margemX = 10;

        //to querendo salvar algumas prioridades para poder escolher a jogada
        /*marcar todas as casas que podem comprar cartas
         * as casas que podem comprar 2 tem prioridade maior
         * marcar o pirata e simbolo que consegue andar mais que 12 casa
         * caso nenhum pirata consiga, procurar mais que 8 casas(ainda to pensando melhor sobre isso)
         * se nao conseguir procurar melhor jogada para comprar
         * ao avançar nunca deixar a casa que avançei com 2 piratas de preferencia(ainda nao sei os detalhes de como fazer isso)
         * 
         * 
         * jogadas para comprar:
         * priorizar bloquear o proximo jogador da vez de comprar duas cartas
         * bloquear é a prioridade maior
         * se nao encontar voltar 2 piratas pra mesma casa
         * (ver 3 piratas em sequencia, volta o do meio e de pois volta o avançado)
         */


        public Tabuleiro()
        {
            listaTabuleiro = new List<string>();
            CasasDoTabuleiro = new List<CasaTabuleiro>();
            piratasTabuleiro = new List<Pirata>();
        }

        public int PosicaoX { get => posicaoX; set => posicaoX = value; }
        public int PosicaoY { get => posicaoY; set => posicaoY = value; }
        public List<string> ListaTabuleiro { get => listaTabuleiro; set => listaTabuleiro = value; }
        public List<CasaTabuleiro> CasasDoTabuleiro { get => casasDoTabuleiro; set => casasDoTabuleiro = value; }
        public List<Pirata> PiratasTabuleiro { get => piratasTabuleiro; set => piratasTabuleiro = value; }

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
                piratasTabuleiro.Add(pirata);
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

            foreach (string item in ListaTabuleiro)  //estava assim foreach (string item in Partida.Tabuleiro.ListaTabuleiro)
            {
                string[] valores = item.Split(',');

                CasaTabuleiro novaCasa = CriaCasa(id);

                if (valores[1] == "T")                                      
                {
                    novaCasa.BackgroundImage = Properties.Resources.TRICORNIO; //Tricornio
                }
                else if (valores[1] == "E")
                {
                    novaCasa.BackgroundImage = Properties.Resources.ESQUELETO; //Esqueleto
                }
                else if (valores[1] == "F")
                {
                    novaCasa.BackgroundImage = Properties.Resources.FACA; //Faca
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
                CasasDoTabuleiro.Add(novaCasa);
            }
        }
        private void DefinePosicoes(Panel pnlTabuleiro)
        {
            int direcao = 0;
            int contaDescida = 0;
            int y = 0, x = 0;

            for (int i = 0; i < CasasDoTabuleiro.Count; i++)
            {
                if ((margemX + (x * CasasDoTabuleiro[i].Width) < width - margemX) && direcao == 0)
                {
                    CasasDoTabuleiro[i].Top = margemY + (y * CasasDoTabuleiro[i].Width);
                    CasasDoTabuleiro[i].Left = margemX + (x * CasasDoTabuleiro[i].Width);

                    if ((margemX + ((x + 1) * piratasTabuleiro[i].Width) < width - margemX))
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
                    CasasDoTabuleiro[i].Left = margemX + (x * CasasDoTabuleiro[i].Width);
                    y++;
                    CasasDoTabuleiro[i].Top = margemY + (y * CasasDoTabuleiro[i].Width);

                    contaDescida++;

                    if ((margemX + (x * CasasDoTabuleiro[i].Width) == margemX) && contaDescida == 2)
                    {
                        direcao = 0;
                        x++;
                    }
                    else if ((margemX + (x * CasasDoTabuleiro[i].Width) < width - margemX) && contaDescida == 2)
                    {
                        direcao = 1;
                    }
                }
                else if ((margemX + (x * CasasDoTabuleiro[i].Width) >= margemX) && direcao == 1)
                {
                    CasasDoTabuleiro[i].Top = margemY + (y * piratasTabuleiro[i].Width);

                    if ((margemX + ((x - 1) * CasasDoTabuleiro[i].Width) > margemX))
                    {
                        x--;
                    }
                    else
                    {
                        x--;
                        contaDescida = 0;
                        direcao = 2;
                    }

                    CasasDoTabuleiro[i].Left = margemX + (x * CasasDoTabuleiro[i].Width);
                }
                pnlTabuleiro.Controls.Add(CasasDoTabuleiro[i]);
            }
        }
        public void CriaMapa(Panel pnlTabuleiro)
        {
            DefineSimbolos();
            DefinePosicoes(pnlTabuleiro);
        }
    }
}
