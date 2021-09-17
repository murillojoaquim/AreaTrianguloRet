using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Digite o valor da base do triângulo");
            string Base = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nAgora, digite o valor da altura:");
            string Altura = Console.ReadLine();

            double areaTriangulo = (Convert.ToDouble(Base) * Convert.ToDouble(Altura)) / 2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nTotal área = {areaTriangulo}");

            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
