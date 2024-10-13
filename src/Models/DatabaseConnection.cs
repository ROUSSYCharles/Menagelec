﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Menagelec.src.Models
{
    abstract class DatabaseConnection
    {
        private const string SERVER = "localhost";
        private const string PORT = "3306";
        private const string DATABASE = "menageleccsharp";
        private const string UID = "menagelec";
        private const string PASSWORD = "MenagelecSIO2024!";


        public static MySqlConnection connect()
        {
            string connectInfo = $"server={SERVER};" +
                                 $"port={PORT};" +
                                 $"database={DATABASE};" +
                                 $"uid={UID};" +
                                 $"password={PASSWORD}";

            MySqlConnection connect = new MySqlConnection(connectInfo);
            connect.Open();
            return connect;
        }

        public MySqlCommand mapParameters(MySqlCommand cmd)
        {
            string modelClassName = this.GetType().ToString();
            string className = modelClassName.Replace("Model", "");
            Type objType = Type.GetType(className);

            object instance = Activator.CreateInstance(objType);
            var getParametersMethod = objType.GetMethod("getParameters");
            var parameters = getParametersMethod.Invoke(instance, null) as Dictionary<string, string>;

            foreach(KeyValuePair<string, string> param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }

            return cmd;
            
        }
    }
}
