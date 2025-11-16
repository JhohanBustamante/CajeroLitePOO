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

        public int GetId()
        {
            return id;
        }
        public int GetPin()
        {
            return pin;
        }

        public Usuario(int id, string nombre, int pin)
        {
            this.id = id;
            this.nombre = nombre;
            this.pin = pin;
        }
    }
}