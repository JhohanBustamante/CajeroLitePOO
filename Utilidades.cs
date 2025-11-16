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
        public string EntradaUsuario(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine() ?? "";
        }
        public void Pausar()
        {
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey(true);
        }

        public string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine() ?? "";
        }




    }
}
