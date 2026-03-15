using DBtools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Academy
{
    public partial class MainForm : Form
    {
        Query[] queries =
        {
            new Query
                ("Stutents,Groups,Directions",
                "last_name,first_name,middle_name,group_name,direction_name",
                "[group]=group_id AND direction=direction_id"),
            new Query
                ("Groups,Directions",
                "group_name,weekdays,start_time,start_date,direction_name",
                "direction=direction_id"),
            new Query("Directions","*"),
            new Query("Disciplines","*"),
            new Query("Teachers","*"),
        };
        DBtools.Connector connector;
        //DBtools.Connector movies_connector;
        
        public MainForm()
        {
            InitializeComponent();
            AllocConsole();
            connector = new DBtools.Connector("Data Source=DESKTOP-LDN2BMM\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //movies_connector = new Connector("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_SPU_411;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //dgvDirections.DataSource = movies_connector.Select("SELECT * FROM Directors;");
            tabControl_SelectedIndexChanged(tabControl, null);
        }
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine($"{(sender as TabControl).SelectedIndex}\t{tabControl.SelectedTab.Text}");
            DataGridView dgv = (this.GetType().GetField($"dgv{tabControl.SelectedTab.Text}").GetValue(this) as DataGridView);
            //dgvDirections.DataSource = connector.Select("SELECT * FROM Directions");
            //toolStripStatusLabel.Text = $"Количество направлений обучения:{dgvDirections.RowCount - 1}";
            dgv.DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
            toolStripStatusLabel.Text = $"Количество записей:{dgv.RowCount - 1}";
        }
    }
}
