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

        public bool ValidarUsuario(int id)
        {
            posicion = ListaUsuarios.FindIndex(usuarioGuardado =>
                usuarioGuardado.GetId() == id
            );
            Console.WriteLine(posicion);
            if (posicion != -1)
            {
                Console.WriteLine("Contiene al usuario");
                return true;
            }
            Console.WriteLine("No contiene al usuario");
            return false;
        }
        
        public long IniciarSesion(int id, int pin)
        {
            return posicion = ListaUsuarios.FindIndex(usuarioGuardado =>
                usuarioGuardado.GetPin() == pin &&
                usuarioGuardado.GetId() == id
            );
        }

        public void GuardarUsuario(Usuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }
    }
}
