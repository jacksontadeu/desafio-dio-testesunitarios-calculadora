using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCalculadora.Utils
{
    public class Menu
    {
        public static void ExibirMenu()
        {
            Console.WriteLine("(1) Digitar Números e escolher operação");
            Console.WriteLine("(2) Últimas operações");
            Console.WriteLine("(3) Sair");

        }
        public static void NomeCalculadora()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("         Calculadora Simples");
            Console.WriteLine("=======================================");
        }

    }
}
