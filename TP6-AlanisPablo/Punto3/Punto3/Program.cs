using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            float resultado;
            do
            {
                Console.Clear();
                Menu();
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        resultado = Suma();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 2:
                        resultado = Resta();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 3:
                        resultado = Producto();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 4:
                        resultado = Division();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 5: Valor_Absoluto();
                        break;
                    case 6: Cuadrado();
                        break;
                    case 7: Raiz();
                        break;
                    case 8: Seno();
                        break;
                    case 9: Coseno();
                        break;
                    case 10: ParteFloat();
                        break;
                }
                MayorMenor();
                Console.WriteLine("¿Desea realizar otra operacion?: (1- Si, 0- No)");
                opc = int.Parse(Console.ReadLine());
            } while (opc != 0);
        }

        static void Menu()
        {
            Console.WriteLine("..... Calculadora .....");
            Console.WriteLine("1- Sumar 2 numeros");
            Console.WriteLine("2- Restar 2 numeros");
            Console.WriteLine("3- Producto entre 2 numeros");
            Console.WriteLine("4- Division entre 2 numeros");
            Console.WriteLine("5- Valor absoluto");
            Console.WriteLine("6- El cuadrado");
            Console.WriteLine("7- La raiz cuadrada");
            Console.WriteLine("8- El seno");
            Console.WriteLine("9- El coseno");
            Console.WriteLine("10- La parte entera de un numero flotante");
            Console.WriteLine("0- Salir.");
            Console.WriteLine("Elija una opcion: ");
        }
        static int Suma()
        {
            int n1, n2;
            Console.WriteLine("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            return n1 + n2;
        }
        static int Resta()
        {
            int n1, n2;
            Console.WriteLine("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            return n1 - n2;
        }
        static int Producto()
        {
            int n1, n2;
            Console.WriteLine("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            return n1 * n2;
        }

        static float Division()
        {
            float n1, n2;
            Console.WriteLine("Ingrese el primer numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            return n1 / n2;
        }
        static void Valor_Absoluto()
        {
            int n1;
            Console.WriteLine("Ingrese el numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El valor absoluto de " + n1 + " es : " + Math.Abs(n1));
        }
        static void Cuadrado()
        {
            int n1;
            Console.WriteLine("Ingrese el numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El cuadrado de " + n1 + " es :" + Math.Pow(n1, 2));
        }
        static void Raiz()
        {
            int n1;
            Console.WriteLine("Ingrese el numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("La raiz cuadrada de " + n1 + " es: " + Math.Sqrt(n1));
        }
        static void Seno()
        {
            int n1;
            Console.WriteLine("Ingrese el numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El seno de " + n1 + " es :" + Math.Sin(n1));
        }
        static void Coseno()
        {
            int n1;
            Console.WriteLine("Ingrese el numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El coseno de " + n1 + " es: " + Math.Cos(n1));
        }
        static void ParteFloat()
        {
            float n1;
            Console.WriteLine("Ingrese el numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("La parte entera de " + n1 + " es: " + Math.Truncate(n1));
        }
        static void MayorMenor()
        {
            int n1, n2;
            Console.WriteLine("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El maximo entre " + n1 + " y " + n2 + " es: " + Math.Max(n1, n2));
            Console.WriteLine("El minimo entre " + n1 + " y " + n2 + " es: " + Math.Min(n1, n2));
        }
    }
}
