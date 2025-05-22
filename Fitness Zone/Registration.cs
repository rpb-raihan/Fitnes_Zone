using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness_Zone
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F4H86BH\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Focus();
            con.Open();
            SqlCommand command = new SqlCommand("insert into registration values ('"+textBox7.Text+"','"+textBox2.Text+"','"+textBox5.Text+"','"+textBox4.Text+"','"+textBox6.Text+"','"+textBox1.Text+"','"+textBox11.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"','"+DateTime.Parse(dateTimePicker1.Text)+"')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Registration Successfull.");
            con.Close();
            textBox7.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Clear();
            textBox11.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            textBox7.Focus();
          /*  dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;  */

            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from registration", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
        void ResetControl()
        {

            textBox7.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Clear();
            textBox11.Clear();
            textBox3.Clear();
        
            textBox7.Focus();
         /*   dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom; */



        }
    }
}
