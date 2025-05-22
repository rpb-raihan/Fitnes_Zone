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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness_Zone
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F4H86BH\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username=textBox1.Text;
            user_password=textBox2.Text;
            try
            {
                String querry = "SELECT * FROM New_login WHERE username='"+textBox1.Text+"'AND password='"+textBox2.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count>0)
                {
                    username=textBox1.Text;
                    user_password=textBox2.Text;
                    // for next page load creat a object
                  Curd m = new Curd();
                    m.Show(); 
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            finally { conn.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.CheckState==CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar=false;
            }
            else { textBox2.UseSystemPasswordChar=true; }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
/*    if (checkBox1.Checked==true)
            {
                textBox2.UseSystemPasswordChar=false;
            }
            else { textBox2.UseSystemPasswordChar=true; } */
