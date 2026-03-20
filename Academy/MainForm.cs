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
        DataGridView[] tables = null;
        Query[] queries =
        {
            new Query
                ("Students,Groups,Directions",
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
        string[] statusBarSignatures =
        {
            "Количество студентов",
            "Количесвто групп",
            "Количество направлений",
            "Количество дисциплин",
            "Количество преподователей"  
        }; 
        DBtools.Connector connector;
        //DBtools.Connector movies_connector;
        
        public MainForm()
        {
            InitializeComponent();
            tables = new DataGridView[]{dgvStudents,dgvGroups,dgvDirections,dgvDisciplines,dgvTeachers};
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
            //dgvDirections.DataSource = connector.Select("SELECT * FROM Directions");
            //toolStripStatusLabel.Text = $"Количество направлений обучения:{dgvDirections.RowCount - 1}";
            //DataGridView dgv = (this.GetType().GetField($"dgv{tabControl.SelectedTab.Text}").GetValue(this) as DataGridView);
            //dgv.DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
            //toolStripStatusLabel.Text = $"Количество записей:{dgv.RowCount - 1}";
            int i = tabControl.SelectedIndex;
            tables[tabControl.SelectedIndex].DataSource = connector.Select(queries[tabControl.SelectedIndex].ToString());
            toolStripStatusLabel.Text = $"{statusBarSignatures[i]}: {tables[i].RowCount - 1}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filterText = button1.Text.Trim();
            //if(string.IsNullOrEmpty(filterText) )
            //{
            //    bindingSource.Filter = null;
            //}
            //else
            //{
            //    bindingSource.Filter = $"Students LIKE '%{filterText}'";
            //}
        }

        private void comboBoxColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBoxColumns.SelectedIndex;
            if(comboBoxColumns.SelectedItem != null )
            {
                string selectedColumn = comboBoxColumns.SelectedItem.ToString();
               
              
            }
        }
    }
}
