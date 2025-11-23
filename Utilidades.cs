using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroLitePOO
{
    internal class Utilidades
    {
        public void Pausar(string texto)
        {
            Console.WriteLine($"{texto}\n");
            Console.ReadKey(true);
        }

        public string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine() ?? "";
        }

        public static string LeerPrivado(string msg)
        {
            Console.Write(msg);
            string s = "";
            ConsoleKeyInfo k;

            while ((k = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (k.Key == ConsoleKey.Backspace && s.Length > 0)
                {
                    s = s[..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(k.KeyChar))
                {
                    s += k.KeyChar;
                    Console.Write("*");
                }
            }

            Console.WriteLine();
            return s;
        }


        public static decimal LeerDecimal(string mensaje)
        {
            decimal valor;

            Console.Write(mensaje);
            while (!decimal.TryParse(Console.ReadLine(), out valor) || valor % 1000 != 0)
            {
                Console.Clear();
                Console.WriteLine("El valor ingrasado es invalido, por favor intente nuevamente: ");
                Console.WriteLine("--Recuerde tener en cuenta: el valor debe ser divisble por 1000-- \n Intente nuevamente: ");
            }
            return valor;
        }

    }
}
