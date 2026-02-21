using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ADO
{
    internal class Connector
    {
        string connection_string;
        SqlConnection connection;
        public Connector(string connection_string)
        {
            this.connection_string = connection_string;
            this.connection = new SqlConnection(connection_string);
        }
        public void Select(string cmd)
        {

            //открываем соединение
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);

            //прочитать данные из базы - открываем reader
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");//если занем скольк полей
                for (int i = 0; i < reader.FieldCount; i++)//если не занем сколько полей
                {
                    Console.Write(reader[i].ToString().PadRight(29));
                }
                Console.WriteLine();
            }
            //зарываем reader
            reader.Close();

            //закрваем соединение
            connection.Close();
        }
    }
}
