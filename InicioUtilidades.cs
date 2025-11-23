using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroLitePOO
{
    internal class InicioUtilidades : Utilidades
    {

        public string ValidarPin(string variable, int digitos)
        {
            string entrada;
            bool esValido = false;
            int intentosFallidos = 0;

            do
            {
                entrada = LeerPrivado("Ingrese su " + variable + ": ");
                int.TryParse(entrada, out _);
                if (intentosFallidos >= 2)
                {
                    Console.WriteLine("Sobrepasaste la cantidad máxima de intentos.");
                    return "";
                }
                if (entrada.Trim().Length != 4 || entrada.Contains(' ')|| !int.TryParse(entrada, out _))
                {
                    esValido = false;
                    intentosFallidos++;
                    Console.WriteLine(variable + " incorrecto.");
                    Pausar("Oprime alguna tecla para intentar de nuevo...");
                    continue;
                }
                esValido = true;
            }
            while (!esValido);
            return entrada;
        }

    }
}
