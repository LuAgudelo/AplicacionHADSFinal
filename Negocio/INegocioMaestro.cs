using Entidades;

namespace Negocio
{
    public interface INegocioMaestro
    {
        List<Ciudad> ObtenerCiudades();
        List<TipoIdentificacion> ObtenerTiposIdentificacion();
        List<EstadoCivil> ObtenerEstadoCivil();
        List<Ocupacion> ObtenerOcupacion();
        List<NivelEscolaridad> ObtenerNivelEscolaridad();
        List<EPS> ObtenerEPS();

    }
}