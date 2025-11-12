using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsCredenciales_CN
    {
        private clsCredenciales_CD ObjCredenciales = new clsCredenciales_CD();

        public bool mtdCValidarCredencialesCN(string Correo, string Clave)
        {
            string PatronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool ValidarCorreo = Regex.IsMatch(Correo, PatronCorreo);

            if (!ValidarCorreo)
            {
                //DETIENE EL METODO Y LANZA EXCEPCION
                throw new FormatException("El formato del correo no es válido.");
            }

            return ObjCredenciales.mtdCValidarCredencialesCD(Correo,Clave);
        }
    }
}
