using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    internal  class Producto
    {
        int CodigoProducto;
        string Nombrepro;
        string Descripcion;

        int PrecioUnit;
        int UnidadExi;

        public Producto()
        {
            CodigoProducto = 0;
            Nombrepro = string.Empty;
            Descripcion = string.Empty;

            PrecioUnit = 0;
            UnidadExi = 0;
        }

        public Producto(int codigoProducto, string nombrepro, string descripcion, int precioUnit, int unidadExi)
        {
            this.CodigoProducto = codigoProducto;
            this.Nombrepro = nombrepro;
            this.Descripcion = descripcion;

            this.PrecioUnit = precioUnit;
            this.UnidadExi = unidadExi;
        }

        public int CodigoProducto1 { get => CodigoProducto; set => CodigoProducto = value; }
        public string Nombrepro1 { get => Nombrepro; set => Nombrepro = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int PrecioUnit1 { get => PrecioUnit; set => PrecioUnit = value; }
        public int UnidadExi1 { get => UnidadExi; set => UnidadExi = value; }


        public string getDatosProductos()
        {
            return " Codigo producto es: " + CodigoProducto + " Nombre producto: " + Nombrepro + " Descripcion: " + Descripcion + " Precio unitario: " + PrecioUnit + " Unidades existentes: " + UnidadExi + "\r\n";
        }
    }
}

