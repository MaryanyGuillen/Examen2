using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class PedidoDA
    {
        readonly string Cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; PWD=Marya10;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarPedidos()
        {
            DataTable listaPedidos = new DataTable();

            try
            {
                string sql = "SELECT * FROM pedido;";
                conn = new MySqlConnection(Cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaPedidos.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaPedidos;
        }

        public int InsertarPedido(Pedido pedido)
        {
            int idPedido = 0;
            try
            {
                string sql = "INSERT INTO factura (Fecha, IdCliente, NombreCliente, Descripcion, Cantidad, PrecioUnidad, Total) VALUES (@Fecha, @IdCliente, @NombreCliente, @Descripcion, @Cantidad, @PrecioUnidad, @Total); select last_insert_idPedido();";

                conn = new MySqlConnection(Cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                cmd.Parameters.AddWithValue("@IdCliente", pedido.IdCliente);
                cmd.Parameters.AddWithValue("@NombreCliente", pedido.NombreCliente);
                cmd.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnidad", pedido.PrecioUnidad);
                cmd.Parameters.AddWithValue("@Total", pedido.Total);
                idPedido = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }
            catch (Exception)
            {
            }
            return idPedido;
        }
    }
}
