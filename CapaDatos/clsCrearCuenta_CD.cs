using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsCrearCuenta_CD
    {
        public void mtdCrearCuentaCD(string NombreUsuario, string Correo,string Clave,
                                   string Nombres, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento, string Telefono)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();
                
                //INSERTAR LOS DATOS DE LA TABLA USUARIO
                string queryUsuario = @"INSERT INTO tbUsuario (NombreUsuario, Correo, Clave)
                                        VALUES (@NombreUsuario, @Correo, @Clave);
                                        SELECT SCOPE_IDENTITY();"; //PARA GUARDAR EL IDUSUARIO GENERADO

                //PREPARAMOS VARIABLE PARA GUARDAR LA ID GENERADA
                int IdUsuario;

                using (SqlCommand cmdUsuario = new SqlCommand(queryUsuario, connection))
                {
                    cmdUsuario.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    cmdUsuario.Parameters.AddWithValue("@Correo", Correo);
                    cmdUsuario.Parameters.AddWithValue("@Clave", Clave);

                    //OBTENER ID
                    IdUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());
                }

                //INSERTAR LOS DATOS DE LA TABLA USUARIODATOS
                string queryDatos = @"INSERT INTO tbUsuarioDatos (idUsuario, Nombres, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Telefono)
                                      VALUES (@idUsuario, @Nombres, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Telefono)";

                using (SqlCommand cmdUsuarioDato = new SqlCommand(queryDatos, connection))
                {
                    cmdUsuarioDato.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    cmdUsuarioDato.Parameters.AddWithValue("@Nombres", Nombres);
                    cmdUsuarioDato.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
                    cmdUsuarioDato.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno);
                    cmdUsuarioDato.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    cmdUsuarioDato.Parameters.AddWithValue("@Telefono", Telefono);

                    cmdUsuarioDato.ExecuteNonQuery();
                }
            }
        }
    }
}
