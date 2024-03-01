using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMaestro : INegocioMaestro
    {
        IRepositorioMaestro repositorioMaestro = new RepositorioMaestroEF();

        public NegocioMaestro()
        {
        }

        public NegocioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }

        public List<Ciudad> ObtenerCiudades()
          => repositorioMaestro.ObtenerCiudades();
        public List<TipoIdentificacion> ObtenerTiposIdentificacion()
        => repositorioMaestro.ObtenerTiposIdentificacion();
        public List<NivelEscolaridad> ObtenerNivelEscolaridad()
        => repositorioMaestro.ObtenerNivelEscolaridad();
        public List<Ocupacion> ObtenerOcupacion()
        => repositorioMaestro.ObtenerOcupacion();
        public List<EPS> ObtenerEPS()
        => repositorioMaestro.ObtenerEPS();
        public List<EstadoCivil> ObtenerEstadoCivil()
        => repositorioMaestro.ObtenerEstadoCivil();

    }
}
