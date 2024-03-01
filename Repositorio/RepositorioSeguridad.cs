using System.Reflection;
using Entidades;

namespace Repositorio
{
    public class RepositorioSeguridad : IRepositorioSeguridad
    {
        private Modelo.Contexto contexto;
        public RepositorioSeguridad()
        {
            contexto = new Modelo.Contexto();
        }

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            var usuarioActual = contexto.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            if (usuarioActual != null)
            {
                return new Usuario()
                {
                    NombreUsuario = usuarioActual.NombreUsuario,
                    Contraseña = usuarioActual.Contraseña
                };
            }

            return null;
        }

    }
}