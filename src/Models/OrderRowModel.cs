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
        public static List<OrderRow> findAllByOrder(Order order)
        {
            List<OrderRow> orderRows = new List<OrderRow>();
            MySqlConnection connection = connect();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT " +
                "p.id as product_id, " +
                "p.designation as product_designation, " +
                "p.description as product_description, " +
                "p.createdAt as product_createdAt, " +
                "p.stock as product_stock, " +
                "p.price as product_price, " +
                "p.imageFilePath as product_imageFilePath, " +
                "order_rows.quantity as orderRow_quantity " +
                "FROM order_rows " +
                "INNER JOIN products as p on order_rows.product = p.id " +
                "INNER JOIN orders as o on order_rows.order = o.id " +
                "WHERE order_rows.order = @id;";
            command.Parameters.AddWithValue("@id", order.getId());

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product().setId(int.Parse(reader[0].ToString()))
                    .setDesignation(reader[1].ToString())
                    .setDescription(reader[2].ToString())
                    .setCreatedAt(DateTime.Parse(reader[3].ToString()))
                    .setStock(int.Parse(reader[4].ToString()))
                    .setPrice(double.Parse(reader[5].ToString()))
                    .setImageFilePath(reader[6].ToString());

                OrderRow newOrderRow = new OrderRow(order, product, int.Parse(reader[7].ToString()));     
                orderRows.Add(newOrderRow);
            }
            connection.Close();
            return orderRows;
        }
    }
    
}
