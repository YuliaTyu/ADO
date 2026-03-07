using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connector
{
    public class Connector
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
        //вставить поле с режиссером!!!! 

        public string GetTableFromInsert(string cmd)
        {
            string[] parts = cmd.Split(' ', '(', ')');
            return parts[1];
        }
        public string GetFieldsFromInsert(string cmd)
        {
            string[] parts = cmd.Split('(', ')');
            return parts[1];
        }
        public string GetValuesFromInsert(string cmd)
        {
            string[] parts = cmd.Split('(', ')');
            return parts[3];
        }
        public void Insert(string cmd)
        {
            Console.WriteLine(cmd);
            Console.WriteLine(GetTableFromInsert(cmd));
            Console.WriteLine(GetFieldsFromInsert(cmd));
            Console.WriteLine(GetValuesFromInsert(cmd));
            if (GetPrimaryKey(GetTableFromInsert(cmd), GetFieldsFromInsert(cmd), GetValuesFromInsert(cmd)) != null) return;
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
        public object GetPrimaryKey(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            object primary_key = command.ExecuteScalar();
            connection.Close();
            return primary_key;
        }
        public object GetPrimaryKey(string table, string fields, string values)
        {
            string[] s_fields = fields.Split(',');
            string[] s_values = values.Split(',');
            if (s_fields.Length != s_values.Length) return null;
            string condition = "";
            for (int i = 0; i < s_values.Length; i++)
            {
                if (s_fields[i].Contains("_id")) continue;
                string value = s_values[i].Trim();
                condition +=
                    (value.Length > 1 && value[0] != 'N' && value[1] != '\'')
                    ? $"{s_fields[i].Trim()}=N'{s_values[i].Trim()}'"
                    : $"{s_fields[i].Trim()}={s_values[i].Trim()}";
                if (i != s_values.Length - 1) condition += " AND ";
            }
            string cmd = $"SELECT  {GetPrimaryKeyColumn(table)} FROM {table} WHERE {condition}";
            return Scalar(cmd);
        }
        public int GetLastPrimaryKey(string table)
        {
            return Convert.ToInt32(Scalar($"SELECT MAX({GetPrimaryKeyColumn(table)}) FROM {table}"));
        }
        public int GetNextPrimaryKey(string table)//узнаем имя первичного ключа
        {
            return GetLastPrimaryKey(table) + 1;
        }
        public void Update(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}

