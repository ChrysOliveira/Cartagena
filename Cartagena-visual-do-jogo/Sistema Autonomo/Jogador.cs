using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo
{
    internal class Jogador
    {
        int ID;
        string Senha;
        string Cor;
        List<Pirata> piratas;

         public Jogador (int ID, string Senha, string Cor)
        {
            this.ID = ID;
            this.Senha = Senha;
            this.Cor = Cor;
            piratas = new List<Pirata>();
            for(int i = 0; i < 6; i++)
            {
                Pirata pirata = new Pirata();
                piratas.Add(pirata);
            }
        }



    }
}
