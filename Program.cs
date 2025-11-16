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

            app.cajero.GuardarUsuario(new Usuario(11, "Kevin", 12234));
            // app.Registrar(new Usuario(11, "Kevin", "12234"));
            app.Registrar();
            
        }

        public bool Registrar()
        {
            string entrada = utilidades.LeerTexto("Ingrese su id de usuario.");
            
            if (!int.TryParse(entrada, out int idUsuario))
            {
                Console.WriteLine("Debe ingresar un número válido.");
                return false;
            }

            if (cajero.ValidarUsuario(idUsuario))
            {
                Console.WriteLine("No se puede registrar");
                return false;
            }
            Console.WriteLine("Se puede registrar");
            //cajero.GuardarUsuario(Usuario usuario);
            return true;
        }
         
    }
}