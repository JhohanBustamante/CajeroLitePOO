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
        
        public virtual string ValidarTexto(string texto, int min, int max)
        {

            return texto;
        }
    }
}
