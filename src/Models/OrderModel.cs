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


            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.setId(int.Parse(reader[0].ToString()))
                    .setDate(DateTime.Parse(reader[1].ToString()))
                    .setIsPayed(bool.Parse(reader[2].ToString()))
                    .setIsExpedited(bool.Parse(reader[3].ToString()));

                Client client = new Client();
                client.setId(int.Parse(reader[4].ToString()))
                    .setCivility(reader[5].ToString())
                    .setLastName(reader[6].ToString())
                    .setName(reader[7].ToString())
                    .setAddress(reader[8].ToString())
                    .setCity(reader[9].ToString())
                    .setPostalCode(reader[10].ToString())
                    .setEmail(reader[11].ToString())
                    .setPhone(reader[12].ToString());

                order.setClient(client);
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }

        public static Order findOrderById(int id)
        {
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
                "INNER JOIN clients as c on o.client = c.id " +
                "WHERE o.id = @id;";
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();


            Order order = new Order().setId(int.Parse(reader[0].ToString()))
                    .setDate(DateTime.Parse(reader[1].ToString()))
                    .setIsPayed(bool.Parse(reader[2].ToString()))
                    .setIsExpedited(bool.Parse(reader[3].ToString()));

            Client client = new Client().setId(int.Parse(reader[4].ToString()))
                    .setCivility(reader[5].ToString())
                    .setLastName(reader[6].ToString())
                    .setName(reader[7].ToString())
                    .setAddress(reader[8].ToString())
                    .setCity(reader[9].ToString())
                    .setPostalCode(reader[10].ToString())
                    .setEmail(reader[11].ToString())
                    .setPhone(reader[12].ToString());

            connection.Close();
            order.setClient(client);
            return order;
        }

        public static List<Order> findOrdersByClientId(int clientId)
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
                "INNER JOIN clients as c on o.client = c.id " +
                "WHERE c.id = @clientId";
            command.Parameters.Add("@clientId", MySqlDbType.Int32).Value = clientId;


            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.setId(int.Parse(reader[0].ToString()))
                    .setDate(DateTime.Parse(reader[1].ToString()))
                    .setIsPayed(bool.Parse(reader[2].ToString()))
                    .setIsExpedited(bool.Parse(reader[3].ToString()));

                Client client = new Client();
                client.setId(int.Parse(reader[4].ToString()))
                    .setCivility(reader[5].ToString())
                    .setLastName(reader[6].ToString())
                    .setName(reader[7].ToString())
                    .setAddress(reader[8].ToString())
                    .setCity(reader[9].ToString())
                    .setPostalCode(reader[10].ToString())
                    .setEmail(reader[11].ToString())
                    .setPhone(reader[12].ToString());

                order.setClient(client);
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }
    }
}
