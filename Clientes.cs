using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    internal class Clientes
    {
        int codigocliente;
        string empresa;
        string nombrecliente;
        string apellidocliente;

        public Clientes()
        {
            codigocliente = 0;
            empresa = string.Empty;
            nombrecliente = string.Empty;
            apellidocliente = string.Empty;
        }

        public Clientes(int codigocliente, string empresa, string nombrecliente, string apellidocliente)
        {
            this.codigocliente = codigocliente;
            this.empresa = empresa;
            this.nombrecliente = nombrecliente;
            this.apellidocliente = apellidocliente;
        }

        public string ApellidoCliente
        {
            get { return apellidocliente; }
            set { apellidocliente = value; }
        }


        public string NombreCliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }


        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string getDatosClientes()
        {
            return " Codigo cliente es: " + codigocliente + " Trabaja en: " + empresa + " y Nombre: " + nombrecliente + " Apellido: " + ApellidoCliente + "\r\n";
        }
    }
}
