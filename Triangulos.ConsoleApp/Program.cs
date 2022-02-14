using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorX, valorY, valorZ;
            string opcao;
            while (true)
            {
                Console.WriteLine("             MENU - Triângulos             \n"
                                 +"Digite 1 para verificar o tipo do triângulo\n"
                                 +"Digite 2 para sair");
                opcao = Console.ReadLine(); 
                if (opcao != "1" && opcao != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (opcao == "1")
                {
                    Console.Write("Digite o valor de X: ");
                    valorX = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor de Y: ");
                    valorY = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor de Z: ");
                    valorZ = Convert.ToDouble(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;
                    if (valorZ > valorX + valorY || valorY > valorX + valorZ || valorX > valorY + valorZ)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Triângulo Inválido! ");
                        Console.ResetColor();
                    }
                    else if (valorX == valorY && valorY == valorZ)
                    {
                        Console.WriteLine("Triângulo Equilátero!");
                    }
                    else if (valorX == valorY || valorX == valorZ || valorY == valorZ)
                    {
                        Console.WriteLine("Triângulo Isósceles!");
                    }
                    else if (valorX != valorY && valorY != valorZ)
                    {
                        Console.WriteLine("Triângulo Escaleno!");
                    }
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;   
                }
                else if(opcao == "2")
                {
                    break;
                }
            }
        }
    }   
}
