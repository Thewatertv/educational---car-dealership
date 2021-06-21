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
    public partial class menu_page : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=SANEK;Initial Catalog=Lada_Avtosalon;Persist Security Info=True;User ID=sa;Password=1");
        SqlCommand command;
        Thread th;
        SqlDataAdapter adapsql = new SqlDataAdapter();
        public menu_page()
        {
            InitializeComponent();

            







        }
        private void menu_page_Load(object sender, EventArgs e)
        {
            
            bool tmp = SqlConnect.connect_open();
            if (!tmp)
            {
                MessageBox.Show("Соединение не установлено!");
                return;
            }




        }

        private void label_FCS_Click(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Add_user);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Form menu_pages = new Form();
            menu_pages.ShowDialog();

        }


        private void open_Add_user(object obj)
        {
            Application.Run(new Add_user());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_List_users);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Form List_users = new Form();
            List_users.ShowDialog();

        }

        private void open_List_users(object obj)
        {
            Application.Run(new List_users());
        }

        private void button_Charts_by_month_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_graph_sales);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Form menu_pages = new Form();
            menu_pages.ShowDialog();
        }

        private void open_graph_sales(object obj)
        {
            Application.Run(new graph_sales());
        }

        private void button_Charts_by_model_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_graph_popularity_model);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Form menu_pages = new Form();
            menu_pages.ShowDialog();
        }



        private void open_graph_popularity_model(object obj)
        {
            Application.Run(new graph_popularity_the_model());
        }

        private void menu_page_Load_1(object sender, EventArgs e)
        {
            textBox_id_index.Text = Static_class_get_set.setfilld();
            try
            {


                // adapsql.InsertCommand = new SqlCommand("SELECT [Name],[Surname],[Middle_name],[Login],[Password],[foto] FROM [dbo].[Staff] where id=20", SqlConnect.sql_con);
                string sql = "SELECT concat([Surname],left([Name],1),'.',left([Middle_name],1),'.') FROM [Staff] where id=" + textBox_id_index.Text + ";";
                adapsql.InsertCommand = new SqlCommand("INSERT [Staff]([Name],[Surname],[Middle_name],[Login],[Password],[foto]) VALUES (@Name,@Surnamel,@Middle_name,@login,@password,@img)", SqlConnect.sql_con);

 
                if (sql_con.State != ConnectionState.Open)
                    sql_con.Open();

                command = new SqlCommand(sql, sql_con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    label_FCS.Text = reader[0].ToString();



                }

                reader.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            try
            {


                
                string sql = "SELECT [foto] FROM [Staff] where id="+ textBox_id_index.Text + ";";

                if (sql_con.State != ConnectionState.Open)
                    sql_con.Open();

                command = new SqlCommand(sql, sql_con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                        pictureBox1.Image = null;
                    else
                    {

                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);

                    }


                }

                reader.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_list_sale);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Form list_sales = new Form();
            list_sales.ShowDialog();

        }

        private void open_list_sale(object obj)
        {
            Application.Run(new list_sales());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sale sale_open = new Sale();


            sale_open.ShowDialog();

        }




    }
}
