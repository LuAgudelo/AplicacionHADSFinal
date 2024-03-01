using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        public List<EPS> ObtenerEPS()
        {
            var eps = new List<EPS>();

            eps.Add(new EPS() { Id = 1, Nombre = "Ninguno" });
            eps.Add(new EPS() { Id = 2, Nombre = "Sanitas" });
            eps.Add(new EPS() { Id = 3, Nombre = "Salud Total" });
            eps.Add(new EPS() { Id = 4, Nombre = "Sura" });
            eps.Add(new EPS() { Id = 5, Nombre = "Nueva EPS" });
            eps.Add(new EPS() { Id = 6, Nombre = "Savia Salud" });
            eps.Add(new EPS() { Id = 7, Nombre = "AIC" });

            return eps;
        }

        public List<TipoIdentificacion> ObtenerTiposIdentificacion()
        {
            var tiposIdentificacion = new List<TipoIdentificacion>();

            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 1, Nombre = "Cédula de Ciudadanía" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 2, Nombre = "Cédula de Extranjería" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 3, Nombre = "Pasaporte" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 4, Nombre = "Registro Civil" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 5, Nombre = "Tarjeta de Identidad" });

            return tiposIdentificacion;
        }

        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            var estadoCivil = new List<EstadoCivil>();

            estadoCivil.Add(new EstadoCivil() { Id = 1, Nombre = "Soltero" });
            estadoCivil.Add(new EstadoCivil() { Id = 2, Nombre = "Casado" });
            estadoCivil.Add(new EstadoCivil() { Id = 3, Nombre = "Unión libre" });
            estadoCivil.Add(new EstadoCivil() { Id = 4, Nombre = "Divorciado" });
            estadoCivil.Add(new EstadoCivil() { Id = 5, Nombre = "Viudo" });

            return estadoCivil;
        }

        public List<Ciudad> ObtenerCiudades()
        {
            var ciudad = new List<Ciudad>();

            ciudad.Add(new Ciudad() { Id = 1, Nombre = "Bogotá" });
            ciudad.Add(new Ciudad() { Id = 2, Nombre = "Medellín" });
            ciudad.Add(new Ciudad() { Id = 3, Nombre = "Cartagena" });
            ciudad.Add(new Ciudad() { Id = 4, Nombre = "Cali" });
            ciudad.Add(new Ciudad() { Id = 5, Nombre = "Santa Marta" });
            ciudad.Add(new Ciudad() { Id = 6, Nombre = "Barranquilla" });
            ciudad.Add(new Ciudad() { Id = 7, Nombre = "Villavicencio" });
            ciudad.Add(new Ciudad() { Id = 8, Nombre = "San Gil" });
            ciudad.Add(new Ciudad() { Id = 9, Nombre = "Bucaramanga" });

            return ciudad;
        }

        public List<NivelEscolaridad> ObtenerNivelEscolaridad()
        {
            var nivelEscolaridads = new List<NivelEscolaridad>();

            nivelEscolaridads.Add(new NivelEscolaridad() { Id = 1, Nombre = "Ninguno" });
            nivelEscolaridads.Add(new NivelEscolaridad() { Id = 2, Nombre = "Preescolar y Primaria" });
            nivelEscolaridads.Add(new NivelEscolaridad() { Id = 3, Nombre = "Básica secundaria y Media técnica" });
            nivelEscolaridads.Add(new NivelEscolaridad() { Id = 4, Nombre = "Técnica profesional y tecnológica" });
            nivelEscolaridads.Add(new NivelEscolaridad() { Id = 5, Nombre = "Profesional Universitario" });
            nivelEscolaridads.Add(new NivelEscolaridad() { Id = 5, Nombre = "Postgrado" });

            return nivelEscolaridads;
        }

        public List<Ocupacion> ObtenerOcupacion()
        {
            var ocupacion = new List<Ocupacion>();

            ocupacion.Add(new Ocupacion() { Id = 1, Nombre = "Abogado" });
            ocupacion.Add(new Ocupacion() { Id = 2, Nombre = "Ingeniero" });
            ocupacion.Add(new Ocupacion() { Id = 3, Nombre = "Profesor" });
            ocupacion.Add(new Ocupacion() { Id = 4, Nombre = "Electricista" });
            ocupacion.Add(new Ocupacion() { Id = 5, Nombre = "Administrador" });
            ocupacion.Add(new Ocupacion() { Id = 6, Nombre = "Contador" });
            ocupacion.Add(new Ocupacion() { Id = 7, Nombre = "Psicológo" });
            ocupacion.Add(new Ocupacion() { Id = 8, Nombre = "Secretaría" });
            ocupacion.Add(new Ocupacion() { Id = 9, Nombre = "Estudiante" });

            return ocupacion;
        }

    }
}
