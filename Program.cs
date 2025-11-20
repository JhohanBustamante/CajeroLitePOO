using CajeroLitePOO;
using System;
namespace CajeroLite.App
{
    public class Program
    {
        private Cajero cajero = new Cajero();
        private Utilidades utilidades = new Utilidades();

        public static void Main()
        {
            Program app = new Program();

            app.cajero.Registrar();
            app.cajero.Registrar();

        }         
    }
}