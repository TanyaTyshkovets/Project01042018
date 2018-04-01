using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_less2
{
    public partial class Form1 : Form
    {
        string conn_str;
        SqlConnection conn = null;

       // public DataTable DataTable { get; private set; }

        public Form1()
        {
            InitializeComponent();
            conn_str = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            conn = new SqlConnection(conn_str);
           // SqlDataAdapter d_adapter = new SqlDataAdapter(conn_str, conn);  // ??
            //SqlCommandBuilder cmdBldr = new SqlCommandBuilder(d_adapter);
            chBUkPr.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image picture = Image.FromFile(@"F:\Море_2017\try.jpg");
            pictureBox1.Image = picture;
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable table = new DataTable();
           // SqlCommand command = new SqlCommand("SELECT *FROM Product");
            SqlDataAdapter d_adapter = new SqlDataAdapter(/*"SELECT *FROM Product"*/"SELECT Product_name as [Product], Price as [Price], CategoryName as [Category] FROM Categories INNER JOIN Product ON Id_Category = CategoryId  ", conn);  
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(d_adapter);
            d_adapter.Fill(table);
      
            conn.Close();
            dataGridView1.DataSource = table;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Product VALUES(@product_name, @price, @id_category", conn); //додаємо дані
            SqlParameter parameter1 = new SqlParameter("@product_name", txtBsurname.Text); // задаємо парам в якому текст введений дорівнює продукт наме
            command.Parameters.Add(parameter1);



            SqlCommand command1 = new SqlCommand("INSERT INTO Categories VALUES(@name)", conn); //додаємо дані
            SqlParameter parameter2 = new SqlParameter("@name", txtBname.Text); // задаємо парам в якому текст введений дорівнює продукт наме
            command1.Parameters.Add(parameter2);
            command1.ExecuteNonQuery();
            conn.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
