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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness_Zone
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F4H86BH\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");

       
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into payment values ('"+textBox1.Text+"','"+textBox5.Text+"','"+comboBox2.Text+"','"+comboBox3.Text+"','"+comboBox1.Text+"','"+textBox2.Text+"','"+DateTime.Parse(dateTimePicker1.Text)+"')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfull Inserted.");
            con.Close();
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from payment ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox5.Clear();
            comboBox1.Text = "";
          /*  dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom; */
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("delete from payment where call='"+textBox2.Text+"'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfull Deleted.");

                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
            /*    dateTimePicker1.CustomFormat = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;   */


                BindData();
            }
            else { MessageBox.Show("No inpute is given"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trainer t = new Trainer();
            t.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TimeClass t = new TimeClass();
            t.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DiatChart h = new DiatChart();
            h.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
            this.Hide();
        }
    }
}
