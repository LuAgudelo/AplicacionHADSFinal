using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorio
{
    public class RepositorioMaestroEF : IRepositorioMaestro
    {
        private Modelo.Contexto contexto;
        public RepositorioMaestroEF()
        {
            contexto = new Modelo.Contexto();
        }

        public List<Ciudad> ObtenerCiudades()
        {
            return contexto.Ciudad
              .Select(c => new Ciudad() { Id = c.Id, Nombre = c.Nombre })
              .OrderBy(c => c.Nombre)
              .ToList();
        }

        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            return contexto.EstadoCivil
                .Select(c => new EstadoCivil() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();
        }

        public List<TipoIdentificacion> ObtenerTiposIdentificacion()
        {
            return contexto.TipoIdentificacion
                .Select(c => new TipoIdentificacion() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();
        }
        public List<Ocupacion> ObtenerOcupacion()
        {
            return contexto.Ocupacion
            .Select(c => new Ocupacion() { Id = c.Id, Nombre = c.Nombre })
            .OrderBy(c => c.Nombre)
            .ToList();
        }
        public List<NivelEscolaridad> ObtenerNivelEscolaridad()
        {
            return contexto.NivelEscolaridad
            .Select(c => new NivelEscolaridad() { Id = c.Id, Nombre = c.Nombre })
            .OrderBy(c => c.Nombre)
            .ToList();
        }

        public List<EPS> ObtenerEPS()
        {
            return contexto.EPS
                .Select(c => new EPS() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();


        }

     
    }
}
