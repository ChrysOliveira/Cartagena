using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo.Classes
{
    public class Estrategia
    {
        private Partida partida;
        private Jogador jogador;

        public Estrategia(Partida partida, Jogador jogador)
        {
            this.partida = partida;
            this.jogador = jogador;
        }
        

    }
}
