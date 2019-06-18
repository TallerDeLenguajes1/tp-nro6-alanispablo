using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            String cade = Console.ReadLine();
            Console.WriteLine();
            mostrarCad(cade);
            busquedaCad(cade);
            separarCad();
            Console.ReadKey();
        }
        static int LongitudStr(String cade)
        {
            return cade.Length;
        }
        static String Concatena(String cade1, String cade2)
        {
            String cade3 = String.Concat(cade1, cade2);
            return cade3;
        }
        static String SubCadena(String cade)
        {
            return cade.Substring(0, 3);
        }
        static void cadenaSuma()
        {
            int n1, n2, resultado;
            String cade;
            Console.WriteLine("Introduzca el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            cade = resultado.ToString();
            Console.WriteLine("La suma entre " + n1.ToString() + " y " + n2.ToString() + " es: " + cade);
        }
        static void mostrarCad(String cade)
        {
            foreach (char cade1 in cade)
            {
                Console.WriteLine(cade1);
            }
        }
        static void busquedaCad(String cade)
        {
            if (cade.IndexOf("m") >= 0) Console.WriteLine("Se encuentra la letra m en la posicion: ");
            int pos = cade.IndexOf("m");
            Console.WriteLine(pos);
        }
        static string mayusculas(string cade)
        {
            return cade.ToUpper();
        }
        static string minusculas(string cade)
        {
            return cade.ToLower();
        }
        static void compararLong(string cade)
        {
            string cade1;
            Console.WriteLine("Ingrese otra frase para comparar: ");
            cade1 = Console.ReadLine();

            if (cade.CompareTo(cade1) > 0)
            {
                Console.WriteLine("La primera cadena ingresada es mas larga.");
            }
            else
            {
                Console.WriteLine("La seguda cadena ingresada es mas larga.");
            }
        }
        static void separarCad()
        {
            string cade;
            char[] delimitadores = { '.', ',', ';' };
            Console.WriteLine("Ingrese una cadena para separar: ");
            cade = Console.ReadLine();
            string[] separada = cade.Split(delimitadores);
            for (int i = 0; i < cade.Length; i++)
            {
                Console.WriteLine("Fragmento {0}= {1}", i, separada[i]);
            }
        }
    }
}
