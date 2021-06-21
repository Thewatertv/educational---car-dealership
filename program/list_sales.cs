using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading;
using System.IO;
using DB_Car_Dealership.static_class;

namespace DB_Car_Dealership
{
    public partial class list_sales : Form
    {
        int index = -1;
        Thread th;

        SqlDataAdapter adapsql = new SqlDataAdapter();
        public list_sales()
        {
            InitializeComponent();
            loadGrid();
        }


        private void loadGrid()
        {

            SqlDataAdapter adapAvto = new SqlDataAdapter("SELECT dbo.Deal.id, dbo.Deal.data, concat( dbo.Customer.First_name,' ', left(dbo.Customer.Second_name,1),'.', left(dbo.Customer.Otchestvo,1),'.'),  concat(dbo.Staff.Surname,' ',left(dbo.Staff.Name,1),'.', left(dbo.Staff.Middle_name,1),'.'),  dbo.Model.Model FROM dbo.Deal INNER JOIN dbo.Customer ON dbo.Deal.id_costomer = dbo.Customer.id INNER JOIN dbo.Staff ON dbo.Deal.id_staff = dbo.Staff.id INNER JOIN dbo.Avtomobil ON dbo.Deal.Code_Of_avto = dbo.Avtomobil.id INNER JOIN dbo.Model ON dbo.Deal.id = dbo.Model.id GROUP BY dbo.Deal.id, dbo.Deal.data, dbo.Customer.First_name, dbo.Customer.Second_name, dbo.Customer.Otchestvo, dbo.Staff.Name, dbo.Staff.Middle_name, dbo.Staff.Surname, dbo.Model.Model", SqlConnect.sql_con);
            DataTable dtAvto = new DataTable();
            adapAvto.Fill(dtAvto);
            dataGridView1.DataSource = dtAvto;

            dataGridView1.Columns[2].HeaderText = "Покупатель";
            dataGridView1.Columns[3].HeaderText = "Продавец";
            dataGridView1.Columns[4].HeaderText = "Модель авто";





        }

        private void buttonVAk_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale sale_open = new Sale();


            sale_open.ShowDialog();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void list_sales_Load(object sender, EventArgs e)
        {

        }

        private void list_sales_Activated(object sender, EventArgs e)
        {

            string  script= @"SELECT dbo.Deal.id,  concat(dbo.Staff.Name, left(dbo.Staff.Surname,1), left(dbo.Staff.Middle_name,1)),concat( dbo.Customer.First_name,' ', left(dbo.Customer.Second_name,1),'.', left(dbo.Customer.Otchestvo,1),'.'),concat( dbo.Complekt.Komplect,' ',dbo.Model.Model),dbo.Komlectacia.Price
                         FROM dbo.Deal INNER JOIN
                         dbo.Avtomobil ON dbo.Deal.Code_Of_avto = dbo.Avtomobil.id INNER JOIN
                         dbo.Komlectacia ON dbo.Avtomobil.Complektacia = dbo.Komlectacia.id INNER JOIN
                         dbo.Model ON dbo.Komlectacia.Model = dbo.Model.id INNER JOIN
                         dbo.Staff ON dbo.Deal.id_staff = dbo.Staff.id INNER JOIN
                         dbo.Customer ON dbo.Deal.id_costomer = dbo.Customer.id INNER JOIN
                         dbo.Complekt ON dbo.Komlectacia.Komplektacia = dbo.Complekt.id";



            SqlDataAdapter adapAvto = new SqlDataAdapter(script, SqlConnect.sql_con);
            DataTable dtAvto = new DataTable();
            adapAvto.Fill(dtAvto);
            dataGridView1.DataSource = dtAvto;

            //dataGridView1.Columns[2].HeaderText = "Покупатель";
            dataGridView1.Columns[3].HeaderText = "Автомобиль";
            //dataGridView1.Columns[4].HeaderText = "Модель авто";

        }
    }
}
