using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }        
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }   
        public decimal PrecioUnidad { get; set; }
        public decimal Total { get; set; }

        public Pedido()
        {

        }

        public Pedido(int idPedido, DateTime fecha, string idCliente, string nombreCliente, string descripcion, int cantidad, decimal precioUnidad, decimal total)
        {
            IdPedido = idPedido;
            Fecha = fecha;
            IdCliente = idCliente;
            NombreCliente = nombreCliente;
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            Total = total;
        }
    }
}
