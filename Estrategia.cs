using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo
{
    internal class Estrategia
    {
        List<Jogador> jogadores;
        Tabuleiro tabuleiro;
        
        public Estrategia(Tabuleiro tabuleiro, List<Jogador> jogadores,List<int> ID, List<string> cor)
        {
            this.tabuleiro = tabuleiro;
            jogadores = new List<Jogador>();
            foreach (int id in jogadores)
            {
                jogadores(ID, cor);
            }
        }
        

        public void JogarSemEstrategia()
        {
            
        }
         
        private int PirataAtrasado(int id)
        {
            for(int i = 0; i <6; i++)
            {
                int casa =
                jogadors[ID].piratas();
            
                
            }
        }
    }
}
