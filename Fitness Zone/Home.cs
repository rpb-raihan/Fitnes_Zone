using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Zone
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TimeClass t = new TimeClass();
            t.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Trainer t = new Trainer();
            t.Show();
            this.Hide(); 

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberShip h = new MemberShip();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration h = new Registration();
            h.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
          DiatChart  h = new DiatChart();
            h.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            About c = new About();
            c.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
