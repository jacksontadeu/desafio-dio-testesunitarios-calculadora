using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCalculadora.Services
{
    public class Calculadora
    {
        public List<string> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            string operacao = "Adiçao";
            int resultado = num1 + num2;
            listaHistorico.Insert(0, $"Resultado da {operacao} = {resultado}");
            return resultado;
        }
        public int Subtrair(int num1, int num2)
        {
            string operacao = "Subtração";
            int resultado = num1 - num2;
            listaHistorico.Insert(0, $"Resultado da {operacao} = {resultado}");
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            string operacao = "Multiplicação";
            int resultado = num1 * num2;
            listaHistorico.Insert(0, $"Resultado da {operacao} = {resultado}");
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            string operacao = "Divisão";
            int resultado = num1 / num2;
            listaHistorico.Insert(0, $"Resultado da {operacao} = {resultado}");
            return resultado;
        }
        public List<string> Historico()
        {
            if (listaHistorico.Count <= 3)
            {
                return listaHistorico;
            }
            else
            {
                
                listaHistorico.RemoveRange(3, listaHistorico.Count -3);
                return listaHistorico;
            }
        }
        
    }
}
