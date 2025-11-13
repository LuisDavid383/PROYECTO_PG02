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
            return ObjCredenciales.mtdCValidarCredencialesCD(Correo,Clave);
        }
    }
}
