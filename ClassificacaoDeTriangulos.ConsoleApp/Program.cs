namespace ClassificacaoDeTriangulos.ConsoleApp
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






                Console.WriteLine("Deseja COntinuar? (s/n)");
                string continuar = Console.ReadLine()!.ToUpper();

                if (continuar != "S")
                    break;
            }
            
        }
    }
}
