using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo.Classes
{
    internal class Utils
    {

        static public List<string> transformaEmLista(string texto)
        {
            List<string> lista = texto.Replace("\r", "").Split('\n').ToList();
            lista.Remove("");
            return lista;
        }
    }
}
