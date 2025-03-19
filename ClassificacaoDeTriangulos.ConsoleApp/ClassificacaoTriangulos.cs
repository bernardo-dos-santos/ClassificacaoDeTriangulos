namespace ClassificacaoDeTriangulos.ConsoleApp
{
    public class ClassificacaoTriangulos
    {
        public static bool TrianguloValido(decimal ladoX, decimal ladoY, decimal ladoZ)
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

        public static decimal LerDado(string qualado)
        {
            decimal valor;
            while (true)
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
        public static void QualTriangulo(decimal ladoX, decimal ladoY, decimal ladoZ)
        {
            if (ladoX == ladoY && ladoY == ladoZ)
                Console.WriteLine("Seu Triângulo é Equilátero");
            else if (ladoZ != ladoX && ladoX != ladoY && ladoZ != ladoY)
                Console.WriteLine("Seu Triângulo é Escaleno");
            else
                Console.WriteLine("Seu Triângulo é Isósceles");
        }

    }

}
