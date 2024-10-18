using Menagelec.Entities;
using MySql.Data.MySqlClient;


namespace Menagelec.src.Models
{
    internal class ProductModel : DatabaseConnection
    {
        public static Product FindById(int id)
        {
            MySqlConnection connection = connect();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM products WHERE id = @id";
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            return new Product()
                .setId(id)
                .setDesignation(reader[1].ToString())
                .setDescription(reader[2].ToString())
                .setImageFilePath(reader[6].ToString())
                .setPrice(double.Parse(reader[5].ToString()));
        }
    }
}