using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        ProductoDA productoDA = new ProductoDA();
        Pedido pedido = new Pedido();
        Producto producto;
        PedidoDA pedidoDA = new PedidoDA();

        

        private void frmPedido_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }

        private void ListarPedidos()
        {
            PedidoDataGridView.DataSource = pedidoDA.ListarPedidos();   
        }
                
        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            pedido.Fecha = FechaDateTimePicker.Value;
            pedido.IdCliente = IdentidadMaskedTextBox.Text;
            pedido.NombreCliente = NombreTextBox.Text;
            pedido.Descripcion = DescripcionTextBox.Text;
            pedido.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            pedido.PrecioUnidad = Convert.ToDecimal(PrecioUnidadTextBox.Text);
            pedido.Total = Convert.ToDecimal(TotalTextBox.Text);

            int idPedido = 0;

            idPedido = pedidoDA.InsertarPedido(pedido);
        }
    }
}
