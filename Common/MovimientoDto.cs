using System;
using System.Collections.Generic;

namespace Common
{
    public class MovimientoDto
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public short TipoMovimiento { get; set; }
        public DateTime FechaMov { get; set; }
    }
}
