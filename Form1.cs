using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prac
{
    public partial class from1 : Form
    {
        List<Clientes> listaClientes = new List<Clientes>();
        List<Producto> listaProductos = new List<Producto>();
        List<Pedido> listaPedidos = new List<Pedido>();



        Clientes clientes;
        Producto producto;
        Pedido pedidos;
        public from1()
        {
            InitializeComponent();


        }


        public void guardarClientes()
        {
            clientes = new Clientes(int.Parse(txtCodigoC.Text), txtEmpresa.Text, txtNomCliente.Text, txtApellidoCliente.Text);

            listaClientes.Add(clientes);
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }


        public void GuardarProducto()
        {
            producto = new Producto(int.Parse(txtCodiProducto.Text), txtNombreProd.Text, txtDescripProduc.Text, int.Parse(txtPrecioUnidad.Text), int.Parse(txtExistentes.Text)); ;

            listaProductos.Add(producto);
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = listaProductos;
        }



        public void GuardarPedido()
        {
            pedidos = new Pedido(int.Parse(txtCodigoPedi.Text), int.Parse(txtNumPedido.Text), int.Parse(txtCodigoCliente.Text), int.Parse(txtCodigoProduct.Text)); ;

            listaPedidos.Add(pedidos);
            dgvPedido.DataSource = null;
            dgvPedido.DataSource = listaPedidos;

            txtCodigoPedi.Clear();
            txtNumPedido.Clear();
            txtCodigoCliente.Clear();
            txtCodigoProduct.Clear();

        }

        private void btnAgre_Click(object sender, EventArgs e)
        {
            GuardarPedido();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarClientes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            getCliente();
        }

        public void getCliente()
        {
            IEnumerable<Clientes> nomEmp = from nEmp in listaClientes select nEmp;

            foreach (Clientes em in nomEmp)
            {
                txtConsultas.AppendText(em.getDatosClientes());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            getPedidos();
        }

        public void getPedidos()

        {
            IEnumerable<Pedido> nomEmp = from nEmp in listaPedidos select nEmp;

            foreach (Pedido em in nomEmp)
            {
                txtConsultas.AppendText(em.getDatosPedidos());
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            getEmpleadoOrdenados();
        }

        public void getEmpleadoOrdenados()
        {
            IEnumerable<Clientes> nomEmp = from nEmp in listaClientes orderby nEmp.NombreCliente descending select nEmp;

            foreach (Clientes em in nomEmp)
            {
                txtConsultas.AppendText(em.getDatosClientes());
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            getProductos();
        }

        public void getProductos()
        
        {
            IEnumerable<Producto> nomEmp = from nEmp in listaProductos select nEmp;

            foreach (Producto em in nomEmp)
            {
                txtConsultas.AppendText(em.getDatosProductos());
            }
        }
    }
    }

