using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CajeroLitePOO
{
    internal class Cajero
    {
        List<Usuario> ListaUsuarios = new List<Usuario>();
        private Utilidades utilidades = new Utilidades();
        private RegistroUtilidades validacionesRegistro = new RegistroUtilidades();
        private InicioUtilidades validacionesInicio = new InicioUtilidades();


        public bool ExistenciaNombre(string nombre)
        {
            int posicion = ListaUsuarios.FindIndex(usuarioGuardado =>
                usuarioGuardado.GetNombre() == nombre
            );
            if (posicion == -1)
            {
                return true;
            }
            return false;
        }

        public bool ExistenciaUsuario(string nombre, string pin)
        {
            int posicion = ListaUsuarios.FindIndex(usuarioRegistrado =>
                usuarioRegistrado.GetNombre() == nombre &&
                usuarioRegistrado.GetPin() == pin
                );
            if (posicion == -1)
            {
                return true;
            }
            return false;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }

        public bool IniciarSesion()
        {
            string nombre;
            string pin;
            int intentosFallidos = 0;

            nombre = validacionesRegistro.ValidarTexto("Nombre de usuario", 4, 10);
            pin = validacionesInicio.ValidarPin("pin", 4);
            do
            {
                intentosFallidos++;
                if (intentosFallidos >=3)
                {
                    Console.WriteLine("Has excedido el número de intentos permitidos. Regresando al menú principal.");
                    return false;
                }
            }
            while (ExistenciaUsuario(nombre,pin));

            return true;
        
        }

        public bool Registrar()
        {
            string nombre = "";
            string pin = "";
            do
            {
                nombre = validacionesRegistro.ValidarTexto("Nombre de usuario", 4, 10);
                if(!ExistenciaNombre(nombre))
                {
                    Console.WriteLine("El nombre de usuario ya existe, por favor elige otro.");
                    utilidades.Pausar("Oprime alguna tecla para intentar de nuevo...");
                    nombre = "";
                }
            }
            while (nombre == "");

            do
            {
                pin = validacionesRegistro.ValidarPin("Pin", 4);
            }
            while (pin == "");


            GuardarUsuario(new Usuario(nombre, pin));
            utilidades.Pausar("Ya puedes iniciar sesion, oprime una tecla para volver al menú principal...");
            return true;
        }

        public void MostrarUsuarios()
        {
            if (ListaUsuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
                return;
            }

            Console.WriteLine("\n=== LISTA DE USUARIOS ===");
            Console.WriteLine("┌─────┬──────────────┬────────┐");
            Console.WriteLine("│ ID  │   Usuario    │  PIN   │");
            Console.WriteLine("├─────┼──────────────┼────────┤");

            foreach (var usuario in ListaUsuarios)
            {
                Console.WriteLine($"│ {usuario.GetId(),-3} │ {usuario.GetNombre(),-12} │ {usuario.GetPin(),-6} │");
            }

            Console.WriteLine("└─────┴──────────────┴────────┘");
            Console.WriteLine($"Total: {ListaUsuarios.Count} usuarios");
        }
    }
}
