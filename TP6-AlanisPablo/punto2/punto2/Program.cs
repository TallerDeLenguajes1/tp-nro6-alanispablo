using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacion, bandera = 1;
            double n1, n2, resultado;

            while (bandera == 1)
            {
                menu();
                operacion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese dos numeros");
                n1 = double.Parse(Console.ReadLine());
                n2 = double.Parse(Console.ReadLine());
                resultado = calculadora(n1, n2, operacion);
                if (resultado != -999.0)
                {
                    Console.WriteLine("Resultado: {0}", resultado);
                }
                Console.WriteLine("Para realizar otra operacion ingrese 1");
                bandera = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("FIN");
            Console.ReadKey();
        }
        public static void menu()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Elija la operacion a realizar");
            Console.WriteLine("1) Suma \n2) Resta \n3) Division \n4) Multiplicacion");
        }
        public static double calculadora(double n1, double n2, int operacion)
        {
            double aux = -9999.0;
            switch (operacion)
            {
                case 1:
                    aux = n1 + n2;
                    break;
                case 2:
                    aux = n1 - n2;
                    break;
                case 3:
                    aux = n1 / n2;
                    break;
                case 4:
                    aux = n1 * n2;
                    break;
                default:
                    Console.WriteLine("No existe la opcion");
                    break;
            }
            return (aux);
        }
    }
}