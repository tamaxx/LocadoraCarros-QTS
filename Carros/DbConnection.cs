
/*

Copyright 2021 Renan Ribeiro Marcelino

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Figurantpp
{
    public class DatabaseConnection : IDisposable
    {
        private readonly MySqlConnection _connection;

        private static readonly string globalConnectionString;

        static DatabaseConnection()
        {
            string server = "localhost";
            string database = "locadora";
            string username = "root";
            string password = "root";

            globalConnectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
        }

        public DatabaseConnection()
        {
            string connectionString = globalConnectionString;

            _connection = new MySqlConnection(connectionString);

            _connection.Open();
        }

        public object Run(string query)
        {
            using (var command = new MySqlCommand(query, _connection))
            {
                return command.ExecuteScalar();
            }
        }

        public object Run(string query, Dictionary<string, object> parameters)
        {
            using (var command = new MySqlCommand(query, _connection))
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                object result = command.ExecuteScalar();
                command.Dispose();

                return result;
            }
        }

        public List<Dictionary<string, object>> Query(string query)
        {
            var result = new List<Dictionary<string, object>>();

            using (var command = new MySqlCommand(query, _connection))
            {

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(Enumerable.Range(0, reader.FieldCount)
                            .ToDictionary(reader.GetName, reader.GetValue));
                    }
                }

                return result;
            }
        }

        public List<IEnumerable<object>> LinearQuery(string query)
        {
            var result = new List<IEnumerable<object>>();

            using (var command = new MySqlCommand(query, _connection))
            {

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        result.Add(Enumerable.Range(0, reader.FieldCount).Select(reader.GetValue));
                    }
                }

                return result;
            }
        }

        public List<Dictionary<string, object>> Query(string query, Dictionary<string, object> parameters)
        {
            var result = new List<Dictionary<string, object>>();

            using (var command = new MySqlCommand(query, _connection))
            {


                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                using (var reader = command.ExecuteReader())
                {


                    while (reader.Read())
                    {
                        result.Add(Enumerable.Range(0, reader.FieldCount)
                            .ToDictionary(reader.GetName, reader.GetValue));
                    }

                    return result;
                }
            }
        }

        public static void Dump(IEnumerable<Dictionary<string, object>> source)
        {
            foreach (var row in source)
            {
                foreach (var col in row)
                {
                    Console.WriteLine($"[{col.Key}] => {col.Value}");
                }

                Console.WriteLine();
            }
        }

        public DataTable DataTableQuery(string commandString)
        {
            MySqlCommand command = new MySqlCommand(commandString, _connection);

            var reader = command.ExecuteReader();

            //

            DataTable table = new DataTable();

            if (reader.HasRows)
            {
                table.Load(reader);
            }

            //

            reader.Close();

            command.Dispose();

            return table;
        }

        public uint GetLastInsertionId()
        {
            return Convert.ToUInt32(Query("select last_insert_id() as 'ID'").First()["ID"]);
        }

        ~DatabaseConnection()
        {
            Dispose();
        }

        public void Dispose()
        {
            _connection.Close();
        }
    }
}
