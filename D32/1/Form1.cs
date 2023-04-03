using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace _1
{
    public partial class Form1 : Form
    {
        string commandText = "SELECT Информация, [Код тура], Название, Цена FROM Туры";
        string connectionString = @".\DATA\Test1.mdf";
        public Form1()
        {
            InitializeComponent();
           
            DataSet dsTours = new DataSet();
            DataTable dtTours = dsTours.Tables.Add("Туры");
            DataColumn dсIDtour = dtTours.Columns.Add("Код тура", typeof(Int32));
            dсIDtour.Unique = true;
            DataColumn dcName = dtTours.Columns.Add("Название");
            DataColumn dcPrice = dtTours.Columns.Add("Цена", typeof(Decimal));
            DataColumn dcInformation = dtTours.Columns.Add("Информация");
            dataGridView1.DataSource = dsTours.Tables["Туры"].DefaultView;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable workTable = new DataTable("Туристы");
            DataColumn dcTouristID = new DataColumn("Код туриста", typeof(int));
            workTable.PrimaryKey = new DataColumn[] { workTable.Columns["Код туриста"] };


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
