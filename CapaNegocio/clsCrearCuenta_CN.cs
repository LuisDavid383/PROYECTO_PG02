using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsCrearCuenta_CN
    {
        private clsCrearCuenta_CD ObjCrearCuenta = new clsCrearCuenta_CD();

        public void mtdCrearCuentaCN(string NombreUsuario, string Correo, string Clave,
                                   string Nombres, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento, string Telefono)
        {
            ObjCrearCuenta.mtdCrearCuentaCD(NombreUsuario, Correo, Clave, Nombres, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Telefono);
        }
    }
}
