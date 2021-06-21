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
    
    public partial class List_users : Form
    {
        int index = -1;
        Thread th;
        
        SqlDataAdapter adapsql = new SqlDataAdapter();

        public List_users()
        {
            InitializeComponent();

            loadGrid();
        }


        private void List_users_Load(object sender, EventArgs e)
        {

        }


        private void loadGrid()
        {
        
            SqlDataAdapter adapAvto = new SqlDataAdapter("SELECT [id],[Name],[Surname],[Middle_name],[Login],[Password],[foto]FROM [dbo].[Staff]", SqlConnect.sql_con);
           DataTable dtAvto = new DataTable();
           adapAvto.Fill(dtAvto);
            dataGridView_staff.DataSource = dtAvto;
            
            
       
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                int id_index = Convert.ToInt32(dataGridView_staff[0, index].Value);
                
                User_Updates user_updates = new User_Updates();
                user_updates.textBox_id.Text = id_index.ToString();

                user_updates.ShowDialog();
                

            }

 

        }




        private void dataGridView_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            
            
        }

        private void dataGridView_staff_Resize(object sender, EventArgs e)
        {
            List_users_Load(sender, e);
    
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

        private void List_users_Activated(object sender, EventArgs e)
        {
            SqlDataAdapter adapAvto = new SqlDataAdapter("SELECT [id],[Name],[Surname],[Middle_name],[Login],[Password],[foto]FROM [dbo].[Staff]", SqlConnect.sql_con);
            DataTable dtAvto = new DataTable();
            adapAvto.Fill(dtAvto);
            dataGridView_staff.DataSource = dtAvto;


        }
    }
}
