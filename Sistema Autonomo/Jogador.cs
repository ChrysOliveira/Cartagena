using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo
{
    public class Jogador
    {
        private int id;

        private string senha;

        private string cor;

        private List<string> maoAtual;

        public int Id { get => id; set => id = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Cor { get => cor; set => cor = value; }
        public List<string> MaoAtual { get => maoAtual; set => maoAtual = value; }
    }
}
