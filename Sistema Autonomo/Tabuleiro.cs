using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo
{
    public class Tabuleiro
    {

        List<string> _tabuleiro;
        List<Pirata> piratas;
        int margemY = 310, margemX = 275;

        public Tabuleiro(List<string> tabuleiro, List<Pirata> piratas)
        {
            this._tabuleiro = tabuleiro;
            this.piratas = piratas;
        }


        private PictureBox CriaPainelPirata()
        {/*
            Panel panelPirata = new Panel();
            panelPirata.BackgroundImageLayout = ImageLayout.Stretch;
            panelPirata.Size = new Size(100, 100);
            panelPirata.Visible = true;
            panelPirata.BringToFront(); */
            PictureBox pictureBoxPirata = new PictureBox();
            pictureBoxPirata.Size = new Size(100, 100);
            pictureBoxPirata.BackgroundImage = Properties.Resources.imagemparateste;
            pictureBoxPirata.BringToFront();
            return pictureBoxPirata;
        }

        PictureBox criado = CriaPainelPirata();
        List<Panel> panelList = new List<Panel>();

        panelList[0].Left = margemX + (pos1[pos * 2] * 50);
                    panelList[0].Top = margemY + (pos1[(pos * 2) + 1] * 50);

            this.Controls.Add(panelList[0]);


        private Panel CriaPainel()
        {
            Panel panel = new Panel();
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.Width = 75;
            panel.Height = 75;
            panel.SendToBack();
            return panel;
        }
        private void CriaMapa()
        {
            List<Panel> panelList = new List<Panel>();

            int y = 0, x = 0;

            foreach (string item in retornoTabuleiro)
            {

                string[] valores = item.Split(',');
                Panel criado = CriaPainel();

                if (valores[0] == "")
                {
                    continue;
                }
                else if (valores[1] == "T")
                {
                    criado.BackgroundImage = Properties.Resources.Tricornio;
                    panelList.Add(criado);

                }
                else if (valores[1] == "E")
                {
                    criado.BackgroundImage = Properties.Resources.Esqueleto;
                    panelList.Add(criado);
                }
                else if (valores[1] == "F")
                {
                    criado.BackgroundImage = Properties.Resources.Faca;
                    panelList.Add(criado);
                }
                else if (valores[1] == "G")
                {
                    criado.BackgroundImage = Properties.Resources.Garrafa;
                    panelList.Add(criado);
                }
                else if (valores[1] == "P")
                {
                    criado.BackgroundImage = Properties.Resources.Pistola;
                    panelList.Add(criado);
                }
                else if (valores[1] == "C")
                {
                    criado.BackgroundImage = Properties.Resources.Chave;
                    panelList.Add(criado);

                }
                else if (valores[1] == " " && valores[0] == "37")
                {
                    //aqui seria o barco
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
                else if (valores[1] == " " && valores[0] == "0")
                {
                    //aqui seria o comeco, antes de entrar no mapa
                    criado.BackgroundImage = Properties.Resources.imagemparateste;
                    panelList.Add(criado);
                }
            }


            int direcao = 0;
            int contaDescida = 0;

            for (int i = 0; i < panelList.Count; i++)
            {
                if ((margemX + (x * panelList[i].Width) < this.Width - margemX) && direcao == 0)
                {
                    panelList[i].Top = margemY + (y * panelList[i].Width);
                    panelList[i].Left = margemX + (x * panelList[i].Width);

                    pos1.Add(x);
                    pos1.Add(y);

                    if ((margemX + ((x + 1) * panelList[i].Width) < this.Width - margemX))
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
                    panelList[i].Left = margemX + (x * panelList[i].Width);
                    y++;
                    panelList[i].Top = margemY + (y * panelList[i].Width);

                    pos1.Add(x);
                    pos1.Add(y);

                    contaDescida++;

                    if ((margemX + (x * panelList[i].Width) == margemX) && contaDescida == 2)
                    {
                        direcao = 0;
                        x++;
                    }
                    else if ((margemX + (x * panelList[i].Width) < this.Width - margemX) && contaDescida == 2)
                    {
                        direcao = 1;
                    }
                }
                else if ((margemX + (x * panelList[i].Width) >= margemX) && direcao == 1)
                {
                    panelList[i].Top = margemY + (y * panelList[i].Width);

                    pos1.Add(x);
                    pos1.Add(y);

                    if ((margemX + ((x - 1) * panelList[i].Width) > margemX))
                    {
                        x--;
                    }
                    else
                    {
                        x--;
                        contaDescida = 0;
                        direcao = 2;
                    }

                    panelList[i].Left = margemX + (x * panelList[i].Width);

                }

                this.Controls.Add(panelList[i]);
            }
        }
    }
}
