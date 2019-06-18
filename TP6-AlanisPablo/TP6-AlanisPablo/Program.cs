using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_AlanisPablo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, aux, nInv = 0;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                aux = n % 10;
                if (n > 9)
                {
                    nInv = (aux + nInv) * 10;
                }
                else
                {
                    nInv = nInv + aux;
                }
                n = n / 10;
            }
            Console.WriteLine("El numero invertido es: " + nInv);
            Console.ReadKey();
        }
    }
}