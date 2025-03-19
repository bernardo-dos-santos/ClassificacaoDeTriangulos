using System;
using System.Runtime.CompilerServices;

namespace ClassificacaoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar1 = true;
            while (true)
            {
                Cabecalho();

                decimal ladoX =  ClassificacaoTriangulos.LerDado("X");
                decimal ladoY =  ClassificacaoTriangulos.LerDado("Y");
                decimal ladoZ =  ClassificacaoTriangulos.LerDado("Z");

                ExibirValores(ladoX, ladoY, ladoZ);

                ClassificacaoTriangulos.TrianguloValido(ladoX, ladoY, ladoZ);

                continuar1 = DesejaContinuar(continuar1);
                
            }
            
        }

        static void Cabecalho()
        {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Classificação de Triângulos");
                Console.WriteLine("-----------------------------------");
        }
        
        
        static void ExibirValores(decimal ladoX, decimal ladoY, decimal ladoZ)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Valores Informados: ");
            Console.WriteLine($"Lado X = {ladoX} ");
            Console.WriteLine($"Lado Y = {ladoY} ");
            Console.WriteLine($"Lado Z = {ladoZ} ");
            Console.ReadLine();
        }


        static bool DesejaContinuar(bool continuar1)
        {
            Console.WriteLine("Deseja Continuar? (s/n)");
            string continuar = Console.ReadLine()!.ToUpper();

            if (continuar != "S" && continuar != "N")
            {
                Console.WriteLine("Comando Inválido, Digite Novamente");
                DesejaContinuar(continuar1);
            }
            else if (continuar != "S")
            {
                Console.WriteLine("Obrigado pela Presença!!");
                Console.ReadLine();
                continuar1 = false;
            }
            else
                continuar1 = true;

            return continuar1;
        }
    }

}
