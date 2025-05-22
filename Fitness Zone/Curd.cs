using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Fitness_Zone
{
    public partial class Curd : Form
    {
        public Curd()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F4H86BH\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");
       
        // Sqp connection name is update and the table name is upto1 
        private void button3_Click(object sender, EventArgs e)
        {

           
            con.Open();
            SqlCommand command = new SqlCommand("insert into Curdfix values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfull Inserted.");
            con.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           

            BindData();

        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Curdfix", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Curdfix set name='"+textBox2.Text+"',number='"+textBox3.Text+"',age='"+textBox4.Text+"' where id='"+textBox1.Text+"'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfull Updated.");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          

            BindData();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("delete from Curdfix where id='"+textBox1.Text+"'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfull Deleted.");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
               

                BindData();
            }
            else { MessageBox.Show("No inpute is given"); } 

            
        
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetControl();

        }
           void ResetControl()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();

        }
    }
}
