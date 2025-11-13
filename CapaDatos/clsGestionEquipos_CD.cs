using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsGestionEquipos_CD
    {
        public void mtdCrearEquipoCD(int IDCreador, string NombreEquipo, string Descripcion)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                //INSERTAR DATOS PARA CREAR EL EQUIPO
                string query_I_Equipo = @"INSERT INTO tbEquipo (IDCreador, NombreEquipo, Descripcion)
                                        VALUES (@IDCreador, @NombreEquipo, @Descripcion);";

                using (SqlCommand cmd_I_Equipo = new SqlCommand(query_I_Equipo, connection))
                {
                    cmd_I_Equipo.Parameters.AddWithValue("@IDCreador", IDCreador);
                    cmd_I_Equipo.Parameters.AddWithValue("@NombreEquipo", NombreEquipo);
                    cmd_I_Equipo.Parameters.AddWithValue("@Descripcion", Descripcion);

                    cmd_I_Equipo.ExecuteNonQuery();
                }
            }
        }
    }
}
