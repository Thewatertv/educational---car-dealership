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
    public partial class User_Updates : Form
    {
        SqlDataAdapter adapsql = new SqlDataAdapter();
        SqlConnection sql_con = new SqlConnection(@"Data Source=SANEK;Initial Catalog=Lada_Avtosalon;Persist Security Info=True;User ID=sa;Password=1");


        SqlCommand command;
        string imgLoc = "";
        public User_Updates()
        {
            InitializeComponent();
        }

        public void User_Updates_Load(object sender, EventArgs e)
        {
           
            
            try {


                // adapsql.InsertCommand = new SqlCommand("SELECT [Name],[Surname],[Middle_name],[Login],[Password],[foto] FROM [dbo].[Staff] where id=20", SqlConnect.sql_con);
                string sql = "SELECT [Name],[Surname],[Middle_name],[Login],[Password],[foto] FROM [dbo].[Staff] where id="+textBox_id.Text+";";
               
                if (sql_con.State != ConnectionState.Open)
                    sql_con.Open();

                command = new SqlCommand(sql, sql_con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox_Name.Text = reader[0].ToString();
                    textBox_Surname.Text = reader[1].ToString();
                    textBox_Middle_name.Text = reader[2].ToString();
                    textBox_login.Text = reader[3].ToString();
                    textBox_password.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[5]);
                    if (img == null)
                        pictureBox1.Image = null;
                    else
                    {

                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);

                    }


                }



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
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();

                    pictureBox1.ImageLocation = imgLoc;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {



            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);


                adapsql.InsertCommand = new SqlCommand("UPDATE [Staff] SET [Name] =@Name,[Surname]=@Surnamel,[Middle_name]=@Middle_name,[Login]=@login,[Password]=@password,[foto]=@img  WHERE id= @id;", SqlConnect.sql_con);
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@Surnamel", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@Middle_name", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@img", img));
                adapsql.InsertCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));

                adapsql.InsertCommand.Parameters[0].Value = textBox_Name.Text;
                adapsql.InsertCommand.Parameters[1].Value = textBox_Surname.Text;
                adapsql.InsertCommand.Parameters[2].Value = textBox_Middle_name.Text;
                adapsql.InsertCommand.Parameters[3].Value = textBox_login.Text;
                adapsql.InsertCommand.Parameters[4].Value = textBox_password.Text;
                
                adapsql.InsertCommand.Parameters[6].Value = Convert.ToInt32(textBox_id.Text);

                adapsql.InsertCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.Close();
            

        }
    }
}
