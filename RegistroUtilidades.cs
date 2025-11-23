using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroLitePOO
{
    internal class RegistroUtilidades : Utilidades
    {

        public string ValidarTexto(string variable, int min, int max)
        {
            string entrada;
            bool esValido;
            do
            {
                entrada = LeerTexto("Ingrese su " + variable + ": ");
                esValido = true;
                if (entrada.Trim().Length < min || entrada.Trim().Length > max || entrada.Contains(' '))
                {
                    esValido = false;
                    Console.WriteLine(variable + " debe tener entre " + min + " y " + max + " caracteres, sin espacios.");
                    Pausar("Oprime alguna tecla para intentar de nuevo...");
                    continue;
                }
                if (int.TryParse(entrada, out _))
                {
                    esValido = false;
                    Console.WriteLine(variable + " no puede ser solo números. ");
                    Pausar("Oprime alguna tecla para intentar de nuevo...");
                    continue;
                }
            }
            while (!esValido);
            return entrada.Trim().ToLower();
        }
        public string ValidarPin(string variable, int digitos)
        {
            string entrada;
            bool esValido;

            do
            {
                entrada = LeerTexto("Ingrese su " + variable + ": ");
                int.TryParse(entrada, out _);
                esValido = true;
                if (entrada.Trim().Length != 4 || entrada.Contains(' '))
                {
                    esValido = false;
                    Console.WriteLine(variable + " debe tener " + digitos + " digitos, sin espacios.");
                    Pausar("Oprime alguna tecla para intentar de nuevo...");
                    continue;
                }
                if (!int.TryParse(entrada, out _))
                {
                    esValido = false;
                    Console.WriteLine(variable + " debe tener solo números.");
                    Pausar("Oprime alguna tecla para intentar de nuevo...");
                    continue;
                }
                string entradaValidacion = LeerTexto("Ingresa nuevamente su " + variable + ": ");
                int.TryParse(entradaValidacion, out _);
                if (entrada != entradaValidacion)
                {
                    esValido = false;
                   
                    Console.WriteLine("No coinciden.");
                    Pausar("Oprime alguna tecla para intentar de nuevo...");
                    continue;
                }
            }
            while (!esValido);
            return entrada.Trim();
        }

    }
}
