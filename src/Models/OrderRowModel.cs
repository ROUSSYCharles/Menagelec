using Menagelec.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagelec.src.Models
{
    internal class OrderRowModel : DatabaseConnection
    {
        public List<OrderRow> findAllByOrderId(int id)
        {
            List<OrderRow> orderRows = new List<OrderRow>();
            MySqlConnection connection = connect();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT " +
                "order_rows.product as orderRow_product, " +
                "order_rows.order as orderRow_order, " +
                "order_rows.quantity as orderRow_quantity, " +
                "INNER JOIN products as p on order_rows.product = p.id, " +
                "INNER JOIN orders as o on order_rows.order = o.id, " +
                "WHERE order_row.product = @id;";
            command.Parameters.AddWithValue("@id", id);

//                this.mapParameters(command);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OrderRow newOrderRow = new OrderRow(null, null, null);
                orderRows.Add(newOrderRow.hydrate(reader, newOrderRow));
            }
            connection.Close();
            return orderRows;
        }
    }
    
}
