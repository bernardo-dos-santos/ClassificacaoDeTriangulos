﻿namespace ClassificacaoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Classificação de Triângulos");
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("Informe o valor do lado X: ");
                decimal ladoX = Decimal.Parse(Console.ReadLine()!);

                Console.WriteLine("Informe o valor do lado Y: ");
                decimal ladoY = Decimal.Parse(Console.ReadLine()!);

                Console.WriteLine("Informe o valor do lado Z: ");
                decimal ladoZ = Decimal.Parse(Console.ReadLine()!);

                Console.WriteLine("Valores Informados: ");
                Console.WriteLine($"Lado X = {ladoX} ");
                Console.WriteLine($"Lado Y = {ladoY} ");
                Console.WriteLine($"Lado Z = {ladoZ} ");

                // verificar se o Triângulo Existe
                if(TrianguloValido(ladoX, ladoY, ladoZ))
                {
                    Console.WriteLine("Valores Válidos");
                    Console.WriteLine("-----------------------------------");
                    QualTriangulo(ladoX, ladoY, ladoZ);
                    Console.WriteLine("-----------------------------------");
                }
                else
                {
                    Console.WriteLine("Valores Inválidos");
                }



                    Console.WriteLine("Deseja COntinuar? (s/n)");
                string continuar = Console.ReadLine()!.ToUpper();

                if (continuar != "S")
                    break;
            }
            
        }
        static bool TrianguloValido(decimal ladoX, decimal ladoY, decimal ladoZ)
        {
            if (ladoX + ladoY >= ladoZ && ladoZ + ladoY >= ladoX && ladoX + ladoZ >= ladoY)
            return true;
            
            else
            return false;
        }
        static void QualTriangulo(decimal ladoX, decimal ladoY, decimal ladoZ)
        {
            if (ladoX == ladoY && ladoY == ladoZ)
                Console.WriteLine("Seu Triângulo é Equilátero");
            else if (ladoZ != ladoX && ladoX != ladoY && ladoZ != ladoY )
                Console.WriteLine("Seu Triângulo é Escaleno");
            else
                Console.WriteLine("Seu Triângulo é Isósceles");
        }
    }

}
