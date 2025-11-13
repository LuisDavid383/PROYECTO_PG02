using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsCredenciales_CD
    {
        //METODO QUE VERIFICA SI EXISTE LAS CREDENCIALES CON LAS CUALES SE QUIERE INGRESAR AL SISTEMA
        public bool mtdCValidarCredencialesCD(string NombreUsuario, string Clave)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string query = "SELECT * FROM tbUsuario WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@Clave", Clave);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //SI EXISTE UNA FILA RETORNARA TRUE
                        return reader.HasRows;
                    }
                }
            }
        }
    }
}
