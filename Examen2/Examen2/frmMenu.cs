using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2
{
    public partial class frmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        frmProducto FrmProducto = null;
        frmPedido FrmPedido = null;

        private void ListaProductosToolStripButton_Click(object sender, EventArgs e)
        {
            if (FrmProducto == null)
            {
                FrmProducto = new frmProducto();
                FrmProducto.MdiParent = this;
                FrmProducto.FormClosed += FrmProducto_FormClosed;
                FrmProducto.Show();
            }
            else
            {
                FrmProducto.Activate();
            }
               
        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProducto = null;
        }
        private void RealizarPedidoToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (FrmPedido == null)
            {
                FrmPedido = new frmPedido();
                FrmPedido.MdiParent = this;
                FrmPedido.FormClosed += FrmPedido_FormClosed;
                FrmPedido.Show();
            }
            else
            {
                FrmPedido.Activate();
            }
        }

        private void FrmPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPedido = null;
        }        
    }
}
