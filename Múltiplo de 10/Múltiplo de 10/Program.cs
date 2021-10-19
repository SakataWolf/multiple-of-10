using System;

namespace Múltiplo_de_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador de 1 a 100");
            Console.WriteLine("Aperte uma tecla para começar");
            Console.ReadKey();
            int x;
            for (x = 1; x <= 100; x++)
            {
                Console.Write("\n\n"+x);
                if (x % 10 == 0)
                {
                    Console.Write("  MÚLTIPLO DE 10");
                } 
            }
        }
    }
}
