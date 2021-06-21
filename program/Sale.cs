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
    public partial class Sale : Form
    {
        int index = -1;
        Thread th;

        SqlDataAdapter adapsql = new SqlDataAdapter();
        

        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
           
            SqlDataAdapter adapAvto = new SqlDataAdapter("SELECT id, concat([Surname],left([Name],1),'.',left([Middle_name],1),'.') FROM dbo.Staff ;", SqlConnect.sql_con);
            DataTable dtAvto = new DataTable();
            adapAvto.Fill(dtAvto);


            this.comboBox_staff.DataSource = dtAvto;
            this.comboBox_staff.DisplayMember = "Column1";
            this.comboBox_staff.ValueMember = "id";
            this.comboBox_staff.SelectedIndex = -1;
            


            SqlDataAdapter adapAvto1 = new SqlDataAdapter("SELECT [id], concat([First_name],left([Second_name],1),'.',left([Otchestvo],1),'.') FROM [dbo].[Customer] ;", SqlConnect.sql_con);
            DataTable dtAvto1 = new DataTable();
            adapAvto1.Fill(dtAvto1);


            this.comboBox_castomer.DataSource = dtAvto1;
            this.comboBox_castomer.DisplayMember = "Column1";
            this.comboBox_castomer.ValueMember = "id";
            this.comboBox_castomer.SelectedIndex = -1;

            SqlDataAdapter adapAvto2 = new SqlDataAdapter("SELECT dbo.Komlectacia.id, concat(dbo.Model.Model,' ', dbo.Complekt.Komplect) FROM dbo.Deal INNER JOIN dbo.Komlectacia ON dbo.Deal.id = dbo.Komlectacia.id INNER JOIN dbo.Model ON dbo.Komlectacia.Model = dbo.Model.id INNER JOIN dbo.Complekt ON dbo.Komlectacia.Komplektacia = dbo.Complekt.id;", SqlConnect.sql_con);
            DataTable dtAvto2 = new DataTable();
            adapAvto2.Fill(dtAvto2);


            this.comboBox_car.DataSource = dtAvto2;
            this.comboBox_car.DisplayMember = "Column1";
            this.comboBox_car.ValueMember = "id";
            this.comboBox_car.SelectedIndex = -1;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(comboBox_castomer.SelectedValue.ToString()); вывод покупателя
            
            adapsql.InsertCommand = new SqlCommand("INSERT INTO [dbo].[Deal]([Code_Of_avto],[id_costomer],[id_staff],[data]) VALUES (@Code_Of_avto,@id_costomer,@id_staff,@data);", SqlConnect.sql_con);
            adapsql.InsertCommand.Parameters.Add(new SqlParameter("@Code_Of_avto", SqlDbType.VarChar));
            adapsql.InsertCommand.Parameters.Add(new SqlParameter("@id_costomer", SqlDbType.VarChar));
            adapsql.InsertCommand.Parameters.Add(new SqlParameter("@id_staff", SqlDbType.VarChar));
            adapsql.InsertCommand.Parameters.Add(new SqlParameter("@data", SqlDbType.VarChar));


            adapsql.InsertCommand.Parameters[0].Value = comboBox_car.SelectedValue.ToString();
            adapsql.InsertCommand.Parameters[1].Value = comboBox_castomer.SelectedValue.ToString();
            adapsql.InsertCommand.Parameters[2].Value = comboBox_staff.SelectedValue.ToString();
            adapsql.InsertCommand.Parameters[3].Value = comboBox_data.Text;

           // SqlConnect.sql_con.Open();

            adapsql.InsertCommand.ExecuteNonQuery();
            SqlConnect.sql_con.Close();

            this.Close();

        }
    }
}
