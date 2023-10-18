using DesafioCalculadora.Services;
using DesafioCalculadora.Utils;
using System.Net.Http.Headers;

namespace DesafioCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            char opcao;
            do
            {
                Console.Clear();
                Menu.NomeCalculadora();
                Menu.ExibirMenu();
                Console.Write("Escolha uma opção: ");
                opcao = char.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case '1':
                        Console.Write("Digite o primeiro número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Write("Escolha a operação( + - * /): ");
                        char operacao = char.Parse(Console.ReadLine());
                        switch (operacao)
                        {
                            case '+':
                                Console.WriteLine($"Resultado: {calc.Somar(num1, num2)}");
                                break;
                            case '-':
                                Console.WriteLine($"Resultado: {calc.Subtrair(num1, num2)}");
                                break;
                            case '*':
                                Console.WriteLine($"Resultado: {calc.Multiplicar(num1, num2)}");
                                break;
                            case '/':
                                Console.WriteLine($"Resultado: {calc.Dividir(num1, num2)}");
                                break;
                            default:
                                Console.Write("Digite uma opção válida!!!");
                                break;
                                
                        }
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        Menu.NomeCalculadora();
                        string[] lista = calc.listaHistorico.Take(3).ToArray();
                        foreach (var e in lista)
                        {
                            Console.WriteLine(e);
                        }
                        Console.ReadKey();
                        break;
                    case '0':
                        Console.WriteLine("Saindo do sistema...Aguarde!!!");
                        Thread.Sleep(3000);
                        break;
                }
            } while (opcao != '0');
            
            
        }

        
    }
}

