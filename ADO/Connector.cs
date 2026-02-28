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
        public void Select(string fields, string tables, string condition = "")
        {
            string cmd = $"SELECT {fields} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            Select(cmd);

        }
        
        //вставить поле с режиссером
        public void Insert(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Insert(string table, string values)
        {
            string cmd = $"INSERT INTO {table} VALUES ({values})";
            Insert(cmd);
        }
        public object Scalar(string cmd)//скалярный запрос - вытаскивающий из базы одно значение
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            //int value = Convert.ToInt32(command.ExecuteScalar());
            object value = command.ExecuteScalar();
            connection.Close();
            return value;
        }
        public string GetPrimaryKeyColumn(string table)
        {
            return (string)Scalar
                (
                $"SELECT\tCOLUMN_NAME FROM\tINFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE WHERE\tCONSTRAINT_NAME=(SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE TABLE_NAME=N'{table}' AND CONSTRAINT_TYPE=N'PRIMARY KEY');"
                );
        }
        public int GetLastPrimaryKey(string table)
        {
            return Convert.ToInt32(Scalar($"SELECT MAX({GetPrimaryKeyColumn(table)}) FROM {table}"));
        }
        public int GetNextPrimaryKey(string table)//узнаем имя первичного ключа
        {
            return GetLastPrimaryKey(table) + 1;
        }
    }
}
