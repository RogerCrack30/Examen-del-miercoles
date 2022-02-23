using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    class Pedido
    {

        private int codigopedido;
        private int numeroPedido;
        private int codigocliente;
        private int codigoproducto;

        public Pedido()
        {
            codigopedido = 0;
            numeroPedido = 0;
            codigocliente = 0;
            codigoproducto = 0;
        }

        public Pedido(int codigopedido, int numeroPedido, int codigocliente, int codigoproducto)
        {
            this.codigopedido = codigopedido;
            this.numeroPedido = numeroPedido;
            this.codigocliente = codigocliente;
            this.codigoproducto = codigoproducto;
        }



        public int CodigoProducto
        {
            get { return codigoproducto; }
            set { codigoproducto = value; }
        }


        public int CodigoCliente
        {
            get { return codigocliente; }
            set { codigocliente = value; }
        }


        public int NumeroPedido
        {
            get { return numeroPedido; }
            set { numeroPedido = value; }
        }

        public string getDatosPedidos()
        {
            return " Codigo pedido es: " + codigopedido + " Numero pedido es: " + numeroPedido + " Codigo cliente es: " + codigocliente + " Codigo pedido es: " + codigoproducto + "\r\n";
        }
    }
}
