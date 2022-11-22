using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double r = 0;

            Console.WriteLine("Digite o numero a ser verificado: ");
            n = Convert.ToInt32(Console.ReadLine());
            r = n % 2;

            if (r == 1 )
            {
                Console.WriteLine("O número é impar");
            }
            else
            {
                Console.WriteLine("O número é par");
            }

            Console.ReadKey();


            


        }
    }
}
