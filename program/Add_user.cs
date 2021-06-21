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
    public partial class Add_user : Form
    {
        Thread th;
        string imgLoc = "";
        SqlDataAdapter adapsql = new SqlDataAdapter();
        public Add_user()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            


            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc,FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                

                adapsql.InsertCommand = new SqlCommand("INSERT [Staff]([Name],[Surname],[Middle_name],[Login],[Password],[foto]) VALUES (@Name,@Surnamel,@Middle_name,@login,@password,@img)", SqlConnect.sql_con);
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@Surnamel", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@Middle_name", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@img", img));

                adapsql.InsertCommand.Parameters[0].Value = textBox_Name.Text;
                adapsql.InsertCommand.Parameters[1].Value = textBox_Surname.Text;
                adapsql.InsertCommand.Parameters[2].Value = textBox_Middle_name.Text;
                adapsql.InsertCommand.Parameters[3].Value = textBox_login.Text;
                adapsql.InsertCommand.Parameters[4].Value = textBox_password.Text;
              

                adapsql.InsertCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button_img_donload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*gif)|*.gif|All Foler (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog()==DialogResult.OK)
                { imgLoc = dlg.FileName.ToString();
                    
                    pictureBox1.ImageLocation = imgLoc;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void Add_user_Load(object sender, EventArgs e)
        {

        }
    }
}
