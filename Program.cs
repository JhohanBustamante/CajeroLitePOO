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
            app.InicioCajero();



        }
        public void InicioCajero()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("         CAJERO AUTOMÁTICO         ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Registrar usuario");
                Console.WriteLine("2. Iniciar sesión");
                Console.WriteLine("3. Salir");
                Console.WriteLine("===================================");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        cajero.Registrar();
                        break;

                    case 2:
                        bool loginExitoso = cajero.IniciarSesion();
                        if (loginExitoso)
                        {
                            Console.WriteLine("Inicio de sesión exitoso.");
                            cajero.MostrarMenuOperaciones();
                        }
                        else
                        {
                            Console.WriteLine("Inicio de sesión fallido.");
                            utilidades.Pausar("Intenta nuevamente...");
                        }
                            break;

                    case 3:
                        Console.WriteLine("Gracias por usar el cajero. ¡Hasta luego!");
                        return; 


                    default:
                        Console.WriteLine("Opción inválida.");
                        utilidades.Pausar("Intente de nuevo...");
                        break;
                }

            } while (opcion != 3);
        }
    }
}