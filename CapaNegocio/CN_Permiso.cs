using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {

        private CD_Permiso objcd_permiso = new CD_Permiso();


        public List<Permiso> Listar(int IdUsuario)
        {
            return objcd_permiso.Listar(IdUsuario);
        }
    }
}
