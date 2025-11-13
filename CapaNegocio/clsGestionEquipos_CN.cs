using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsGestionEquipos_CN
    {
        private clsGestionEquipos_CD ObjgestionEquipos = new clsGestionEquipos_CD();

        public void mtdCrearEquipoCN(int IDCreador, string NombreEquipo, string Descripcion)
        {
            ObjgestionEquipos.mtdCrearEquipoCD(IDCreador, NombreEquipo, Descripcion);
        }
    }
}
