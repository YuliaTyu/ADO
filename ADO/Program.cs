using System;
using System.Collections.Generic;
using System.Data.SqlClient;//подлючаем базу
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //создаем соедиенеие
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_SPU_411;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//из свойств Movies_SPU_411 вытаскавем строку 
            SqlConnection connection = new SqlConnection(connection_string);
            string cmd = "SELECT title,year,first_name,last_name FROM Movies JOIN Directors ON(director=director_id)";
            
            //Connector connector = new Connector(connection_string);
            //connector.Select("title,year,first_name,last_name","Movies,Directors","director=director_id");
            //Console.WriteLine("\n------------------ -\n");

            ////Console.WriteLine(connector.Scalar("SELECT MAX(director_id)FROM Directors"));

            //string table = "Movies";
            //Console.WriteLine(connector.GetNextPrimaryKey(table));
            //Console.WriteLine(connector.GetLastPrimaryKey(table));
            //Console.WriteLine(connector.GetPrimaryKeyColumn(table));

            //connector.Insert($"IF NOT EXISTS (SELECT * FROM Directors WHERE last_name=N'Besson' AND first_name=N'Luc') " +
            //    $"INSERT Directors VALUES({connector.GetNextPrimaryKey("Directors")},N'Besson',N'Luc')");//запись не дублируется!!! но код не идеален
            ////connector.Insert("Directors", $"{connector.GetNextPrimaryKey("Directors")},N'Besson',N'Luc'");//добавляем режиссера!!!!!!!!!!!
            //connector.Update("UPDATE Directors SET last_name=N'Lettich',first_name=N'Sheldon' WHERE director_id=8");
            //connector.Select("*", "Directors");
            //Console.WriteLine("\n------------------ -\n");
            //connector.Select(cmd);


        }
    }
}
