using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace DB_Car_Dealership
{
    public partial class graph_sales : Form
    {
        //SqlDataAdapter adapsql = new SqlDataAdapter();
        SqlDataAdapter sda = new SqlDataAdapter();
        Thread th;
        public graph_sales()
        {
            InitializeComponent();


        }

        private void graph_sales_Load(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT data, COUNT(*) AS CNT FROM Deal GROUP BY data HAVING COUNT(*) > 0;", SqlConnect.sql_con);
            DataTable dt3 = new DataTable();
            sda.Fill(dt3);
            dataGridView1.DataSource = dt3;
           
            chart1.DataSource= dt3;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            Dictionary<string, int> Data = new Dictionary<string, int>();
            

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string x = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                int y = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                chart1.Series[0].Points.AddXY(x, y);

            }
            
            Data.Add("ㅤ", 0);
            foreach (var r in Data)
            {
                chart1.Series[0].Points.AddXY(r.Key, r.Value); ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_menu_pages);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Form menu_pages = new Form();
            menu_pages.ShowDialog();
        }

        private void open_menu_pages(object obj)
        {
            Application.Run(new menu_page());
        }

    }
}
