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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            ListaProductosDataGridView.DataSource = productoDA.ListarProductos();
        }
        string operacion = string.Empty;
        ProductoDA productoDA = new ProductoDA();

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true; 
            
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
            ModificarButton.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;

            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
            ModificarButton.Enabled = true;

        }
        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el código");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox, "Ingrese una descripción");
                    DescripcionTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese un precio");
                    PrecioTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciaTextBox.Text))
                {
                    errorProvider1.SetError(ExistenciaTextBox, "Ingrese una existencia");
                    ExistenciaTextBox.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.Codigo = CodigoTextBox.Text;
                producto.Descripcion = DescripcionTextBox.Text;
                producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);
                               
                if (operacion == "Nuevo")
                {
                    bool inserto = productoDA.InsertarProducto(producto);

                    if (inserto)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto insertado");
                    }
                }
                else if (operacion == "Modificar")
                {
                    bool modifico = productoDA.ModificarProducto(producto);
                    if (modifico)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto modificado");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ListaProductosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = ListaProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox.Text = ListaProductosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                PrecioTextBox.Text = ListaProductosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciaTextBox.Text = ListaProductosDataGridView.CurrentRow.Cells["Existencia"].Value.ToString();

                HabilitarControles();
                CodigoTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un producto");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ListaProductosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = productoDA.EliminarProducto(ListaProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("Producto eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

       
    }
}
