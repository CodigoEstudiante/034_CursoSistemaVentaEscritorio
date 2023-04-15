using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteCompra
    {
        public string FechaRegistro { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string MontoTotal { get; set; }
        public string UsuarioRegistro { get; set; }
        public string DocumentoProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public string Cantidad { get; set; }
        public string SubTotal { get; set; }

    }
}
