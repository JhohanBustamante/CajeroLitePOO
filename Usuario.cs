using CajeroLite.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroLitePOO
{
    public class Usuario: Program
    {
        private int id { get; set; } //declarativo
        private string nombre { get; set; }
        private int pin { get; set; }
        private static int contador = 0;

        public int GetId()
        {
            return id;
        }
        public int GetPin()
        {
            return pin;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public Usuario(string nombre, int pin)
        {   
            contador++;
            this.id = contador;
            this.nombre = nombre;
            this.pin = pin;
        }
    }
}