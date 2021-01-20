//using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
using System;

namespace CADAplicacionComercial
{
    public class CADUsuario
    {
        private static UsuarioTableAdapter adaptador = new UsuarioTableAdapter();
        public static bool ValidaUsuario(string IDUsuario, string Clave)
        {

            return (int)adaptador.ValidaUsuario(IDUsuario, Clave)==1;
        }

    }
}
