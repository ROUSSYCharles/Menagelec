using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace Menagelec.Entities
{
    abstract public class AbstractEntity<T> where T : class
    {
        public T hydrate(MySqlDataReader stmtRow, object obj)
        {
            // Obtenir le type de l'objet à hydrater
            Type objectType = obj.GetType();

            // Boucler sur chaque propriété du stmtRow (généralement un dictionnaire ou un DataReader)
            foreach (var property in stmtRow.GetType().GetProperties())
            {
                string attribute = property.Name;
                object value = property.GetValue(stmtRow);

                if (value != null)
                {
                    // Générer le nom du setter
                    string className = objectType.Name.ToLower();
                    string[] attributeParts = attribute.Split('_');
                    string prefix = attributeParts[0];

                    // Si le préfixe correspond au nom de la classe, on l'enlève
                    if (prefix.ToLower() == className)
                    {
                        attribute = string.Join("_", attributeParts, 1, attributeParts.Length - 1);
                    }

                    // Convertir les underscore en CamelCase pour le setter
                    string method = "Set" + ToPascalCase(attribute);

                    // Vérifier si le setter existe et est callable
                    MethodInfo methodInfo = objectType.GetMethod(method);
                    if (methodInfo != null && methodInfo.IsPublic)
                    {
                        // Obtenir le type du paramètre du setter
                        ParameterInfo[] parameters = methodInfo.GetParameters();
                        if (parameters.Length == 1)
                        {
                            Type paramType = parameters[0].ParameterType;

                            // Si le setter attend un DateTime ou DateTimeImmutable
                            if (paramType == typeof(DateTime))
                            {
                                value = Convert.ToDateTime(value);
                            }

                            // Appeler le setter avec la valeur correspondante
                            methodInfo.Invoke(obj, new[] { Convert.ChangeType(value, paramType) });
                        }
                    }
                }
            }
            return this as T;
        }

        // Fonction utilitaire pour convertir un attribut avec des underscores en CamelCase
        private static string ToPascalCase(string str)
        {
            string[] parts = str.Split('_');
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = char.ToUpper(parts[i][0]) + parts[i].Substring(1);
            }
            return string.Join(string.Empty, parts);
        }



        private PropertyInfo[] getAttributes()
        {
            return this.GetType().GetProperties();
        }

        public Dictionary<string, string> getParameters()
        {
            Dictionary<string, string> aliasAttributeMap = new Dictionary<string, string>();
            PropertyInfo[] properties = getAttributes();


            foreach (PropertyInfo property in properties)
            {
                string alias = $"{this.GetType().ToString().ToLower()}s_{property.Name}";
                string name = property.Name;
                aliasAttributeMap.Add(alias, name);
            }

            return aliasAttributeMap;
        }

    }

}
