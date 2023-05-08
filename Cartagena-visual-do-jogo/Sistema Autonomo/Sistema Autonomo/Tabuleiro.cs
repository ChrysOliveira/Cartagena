using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo
{
    public class Tabuleiro
    {

        List<string> _tabuleiro;
        List<Pirata> piratas;

        public Tabuleiro(List<string> tabuleiro, List<Pirata> piratas)
        {
            this._tabuleiro = tabuleiro;
            this.piratas = piratas;
        }
    }
}
