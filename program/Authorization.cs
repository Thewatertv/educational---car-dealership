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
using DB_Car_Dealership.static_class;




namespace DB_Car_Dealership
{
   
    public partial class Authorization : Form
    {
        Thread th;
        string index_id_t;
        public Authorization()
        {
            InitializeComponent();

        }

        private void Avtosalon_Load(object sender, EventArgs e)
        {
            bool tmp = SqlConnect.connect_open();
            if (!tmp)
            {
                MessageBox.Show("Соединение не установлено!");
                return;
            }

        }




        private void Authorization_Load(object sender, EventArgs e)
        {

            this.staffTableAdapter.Fill(this.lada_AvtosalonDataSet.Staff);
            bool tmp = SqlConnect.connect_open();
            if (!tmp)
            {
                MessageBox.Show("Соединение не установлено!");
                return;
            }

        }

        

        private void Login_button_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Staff where id = '" + comboBox_login.SelectedValue.ToString() + "' and Password = '" + textBox_Password.Text + "'", SqlConnect.sql_con);
            Static_class_get_set.getfilld(comboBox_login.SelectedValue.ToString());
            DataTable dt = new DataTable();
            sda.Fill(dt);

          
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Close();
                th = new Thread(open_menu_pages);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                Form menu_pages = new Form();
                menu_pages.ShowDialog();
            }
            else
            { MessageBox.Show("Неправельный пароль"); }

            ;

            





        }

        private void open_menu_pages(object obj)
        {
            Application.Run(new menu_page());

            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


        
    }
