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
        private string senha;
        public string cor;
        List<Pirata> piratas;
        List<string> cartas;
        

         public Jogador (int ID, string Senha, string Cor)
        {
            this.ID = ID;
            this.senha = Senha;
            this.cor = Cor;
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
            this.senha = cor;
            piratas = new List<Pirata>();
            for (int i = 0; i < 6; i++)
            {
                Pirata pirata = new Pirata(i);
                piratas.Add(pirata);
            }
        }

        public List<Pirata> Piratas { get { return piratas; } }
        public int PirataCasa(int id) { return piratas[id].PosicaoNaLista; }

        public int Id { get { return ID; } }
        public string Senha { get { return Senha; } }

        public string Cor { get { return Cor; } }

        public void ADDCartas(string carta)
        {
            cartas.Add(carta);
        }
        public string EscolherCarta()
        {
            string cartaEscolhida = cartas[0];
            cartas.Remove(0);
            return cartaEscolhida;
        }


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
