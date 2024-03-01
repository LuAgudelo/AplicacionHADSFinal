using Entidades;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Ciudad> ObtenerCiudades();
        List<TipoIdentificacion> ObtenerTiposIdentificacion();
        List<NivelEscolaridad> ObtenerNivelEscolaridad();
        List<Ocupacion> ObtenerOcupacion();
        List<EPS> ObtenerEPS();
        List<EstadoCivil> ObtenerEstadoCivil();
    }
}