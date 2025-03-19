using System;
using System.Runtime.CompilerServices;

namespace ClassificacaoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Cabecalho();

                decimal ladoX = LerDado("X");
                decimal ladoY = LerDado("Y");
                decimal ladoZ = LerDado("Z");

                ExibirValores(ladoX, ladoY, ladoZ);

                TrianguloValido(ladoX, ladoY, ladoZ);
               
                
                Console.WriteLine("Deseja COntinuar? (s/n)");
                string continuar = Console.ReadLine()!.ToUpper();

                if (continuar != "S")
                    break;
            }
            
        }

        static void Cabecalho()
        {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Classificação de Triângulos");
                Console.WriteLine("-----------------------------------");
        }
        static bool TrianguloValido(decimal ladoX, decimal ladoY, decimal ladoZ)
        {
            if (ladoX + ladoY >= ladoZ && ladoZ + ladoY >= ladoX && ladoX + ladoZ >= ladoY)
            {
                Console.WriteLine("Valores Válidos");
                Console.WriteLine("-----------------------------------");
                QualTriangulo(ladoX, ladoY, ladoZ);
                Console.WriteLine("-----------------------------------");
                return true;
            }
            else
            {
                Console.WriteLine("Esse Triângulo é Inválido ");
                return false;
            }
            
        }
        public static void QualTriangulo(decimal ladoX, decimal ladoY, decimal ladoZ)
        {
            if (ladoX == ladoY && ladoY == ladoZ)
                Console.WriteLine("Seu Triângulo é Equilátero");
            else if (ladoZ != ladoX && ladoX != ladoY && ladoZ != ladoY )
                Console.WriteLine("Seu Triângulo é Escaleno");
            else
                Console.WriteLine("Seu Triângulo é Isósceles");
        }
        static decimal LerDado (string qualado)
        {
            decimal valor;
            while(true)
            {
                Console.WriteLine($"Informe o valor do lado {qualado}");
                bool ehNumero = decimal.TryParse(Console.ReadLine(), out valor);
                if (ehNumero)
                    break;
                else
                    Console.WriteLine("Números Inválidos, Digite Novamente");
            }
            return valor;
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
    }

}
