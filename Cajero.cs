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
        private int posicion;
        private Utilidades utilidades = new Utilidades();
        private Validaciones validaciones = new Validaciones();

        public bool ExistenciaNombre(string nombre)
        {
            posicion = ListaUsuarios.FindIndex(usuarioGuardado =>
                usuarioGuardado.GetNombre() == nombre
            );
            if (posicion != -1)
            {
                Console.WriteLine("True, posicion != -1, existe el nombre");
                return true;
            }
            Console.WriteLine("False, posicion == -1, no existe el nombre");
            return false;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }

        public bool IniciarSesion()
        {
            int pin= 0;
            int id= 0;
            try
            {
                posicion = ListaUsuarios.FindIndex(usuarioGuardado =>
                usuarioGuardado.GetPin() == pin &&
                usuarioGuardado.GetId() == id
                );
                if (posicion != -1)
                {
                    return true;
                }
                return false;
            } catch (Exception error)
            {
                Console.WriteLine("Error al iniciar sesión: " + error.Message);
                return false;
            }         
        }

        public bool Registrar()
        {
            string nombre;
            int pin;
            do
            {
                nombre = validaciones.ValidarTexto("Nombre de usuario", 4, 10);
            }
            while (ExistenciaNombre(nombre));
            pin = validaciones.ValidarNumero("Pin", 4);
            Console.WriteLine("Registrado");
            GuardarUsuario(new Usuario(nombre,pin));
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
