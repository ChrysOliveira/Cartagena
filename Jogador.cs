using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo
{
    public class Jogador
    {
        int ID;
        private string Senha;
        public string Cor;
        List<Pirata> piratas;
        

         public Jogador (int ID, string Senha, string Cor)
        {
            this.ID = ID;
            this.Senha = Senha;
            this.Cor = Cor;
            piratas = new List<Pirata>();
            for(int i = 0; i < 6; i++)
            {
                Pirata pirata = new Pirata(i);
                piratas.Add(pirata);
            }
        }
        public Jogador (int ID, string cor)
        {
            this.ID = ID;
            this.Senha = cor;
            piratas = new List<Pirata>();
            for (int i = 0; i < 6; i++)
            {
                Pirata pirata = new Pirata(i);
                piratas.Add(pirata);
            }
        }

        public List<Pirata> Piratas { get { return piratas; } }

        public int Id { get { return ID; } }
        public string senha { get { return Senha; } }

        public string cor { get { return Cor; } }


        public int ObterCasaDoPirata(int posicaoDoPirata)
        {
            return Piratas[posicaoDoPirata].Casa;
        }


        public void Av_Pirata(int IdPirata,string simbolo, int NovaCasa)
        {
            Jogo.Jogar(ID, Senha, piratas[IdPirata].Casa, simbolo);
            piratas[IdPirata].AvancaPirata(NovaCasa, simbolo);

        }

        public void Volt_Pirata(int IdPirata, int NovaCasa, string NovoSimbolo)
        {
            Jogo.Jogar(ID, Senha, piratas[IdPirata].Casa);
            piratas[IdPirata].VoltarPirata(NovaCasa, NovoSimbolo);


        }

        public void Pular()
        {
            Jogo.Jogar(ID, Senha);
        }

        
    }
}
