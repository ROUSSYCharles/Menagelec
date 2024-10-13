using Menagelec.Entities;
using Menagelec.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Menagelec.src.Models
{
    internal class OrderModel : DatabaseConnection
    {
        public static List<Order> findAllOrders()
        {
            List<Order> orders = new List<Order>();
            MySqlConnection connection = connect();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT " +
                "o.id as order_id, " +
                "o.date as order_date, " +
                "o.isPayed as order_isPayed, " +
                "o.isExpedited as order_isExpedited, " +
                "c.id as client_id, " +
                "c.civility as client_civility, " +
                "c.lastName as client_lastName, " +
                "c.name as client_name, " +
                "c.address as client_address, " +
                "c.city as client_city, " +
                "c.postalCode as client_postalCode, " +
                "c.email as client_email, " +
                "c.phone as client_phone " +
                "FROM orders as o " +
                "INNER JOIN clients as c on o.client = c.id;";


//            this.mapParameters(command);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.setId(int.Parse(reader[0].ToString()))
                    .setDate(DateTime.Parse(reader[1].ToString()))
                    .setIsPayed(bool.Parse(reader[2].ToString()))
                    .setIsExpedited(bool.Parse(reader[3].ToString()));

                Client client = new Client();
                client.setId(int.Parse(reader[4].ToString()));
                client.setCivility(reader[5].ToString());
                client.setLastName(reader[6].ToString());
                client.setName(reader[7].ToString());
                client.setAddress(reader[8].ToString());
                client.setCity(reader[9].ToString());
                client.setPostalCode(reader[10].ToString());
                client.setEmail(reader[11].ToString());
                client.setPhone(reader[12].ToString());

                order.setClient(client);
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }
    }
}
