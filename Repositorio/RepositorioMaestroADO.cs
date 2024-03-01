using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroADO : IRepositorioMaestro
    {
        public List<TipoIdentificacion> ObtenerTiposIdentificacion()
        {
            var tipoIdentificacion = new List<TipoIdentificacion>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["conexionAplicacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM TipoIdentificacion ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tipoIdentificacion.Add(new TipoIdentificacion()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return tipoIdentificacion;
        }

        public List<Ciudad> ObtenerCiudades()
        {
            var ciudad = new List<Ciudad>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["conexionAplicacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM Ciudad ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ciudad.Add(new Ciudad()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return ciudad;
        }

        public List<NivelEscolaridad> ObtenerNivelEscolaridad()
        {
            var nivelEscolaridad = new List<NivelEscolaridad>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["conexionAplicacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM NivelEscolaridad ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nivelEscolaridad.Add(new NivelEscolaridad()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return nivelEscolaridad;
        }

        public List<EPS> ObtenerEPS()
        {
            var Eps = new List<EPS>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["conexionAplicacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM EPS ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Eps.Add(new EPS()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return Eps;
        }

        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            var estadoCivil = new List<EstadoCivil>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["conexionAplicacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM EstadoCivil ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estadoCivil.Add(new EstadoCivil()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return estadoCivil;
        }

        public List<Ocupacion> ObtenerOcupacion()
        {
            var Ocupacion = new List<Ocupacion>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["conexionAplicacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM Ocupacion ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ocupacion.Add(new Ocupacion()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return Ocupacion;
        }

    }

}
